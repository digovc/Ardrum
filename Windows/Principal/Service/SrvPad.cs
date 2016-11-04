using System;
using System.Threading;
using Ardrum.Dominio;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using DigoFramework.Service;

namespace Ardrum.Service
{
    public class SrvPad : ServiceBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private int _intToqueVolume;
        private ISoundOut _objSoundOut;
        private IWaveSource _objWave;
        private PadDominio _pad;

        public PadDominio pad
        {
            get
            {
                return _pad;
            }

            set
            {
                _pad = value;
            }
        }

        private int intToqueVolume
        {
            get
            {
                return _intToqueVolume;
            }

            set
            {
                _intToqueVolume = value;
            }
        }

        private ISoundOut objSoundOut
        {
            get
            {
                if (_objSoundOut != null)
                {
                    return _objSoundOut;
                }

                _objSoundOut = this.getObjSoundOut();

                return _objSoundOut;
            }
        }

        private IWaveSource objWave
        {
            get
            {
                if (_objWave != null)
                {
                    return _objWave;
                }

                _objWave = this.getObjWave();

                return _objWave;
            }
        }

        #endregion Atributos

        #region Construtores

        public SrvPad(PadDominio pad) : base("Serviço do pad " + pad.strNome)
        {
            this.pad = pad;
        }

        #endregion Construtores

        #region Métodos

        internal void tocar(int intToqueVolume)
        {
            this.intToqueVolume = intToqueVolume;
        }

        protected override void servico()
        {
            while (!this.booParar)
            {
                this.loop();

                Thread.Sleep(1);
            }
        }

        private ISoundOut getObjSoundOut()
        {
            ISoundOut objSoundOutResultado = new WasapiOut() { Latency = 25, Device = AppArdrum.i.objDevice };

            objSoundOutResultado.Initialize(this.objWave);

            return objSoundOutResultado;
        }

        private IWaveSource getObjWave()
        {
            IWaveSource objWaveResultado = CodecFactory.Instance.GetCodec(this.pad.dirAudio)
                .ToSampleSource()
                .ToMono()
                .ToWaveSource();

            return objWaveResultado;
        }

        private void loop()
        {
            this.tocar();
        }

        private void tocar()
        {
            if (this.intToqueVolume < 1)
            {
                return;
            }

            this.objWave.SetPosition(TimeSpan.Zero);
            this.objSoundOut.Play();
            this.intToqueVolume = 0;
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}