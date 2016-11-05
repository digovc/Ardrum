using System;
using System.Threading;
using Ardrum.Dominio;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using CSCore.Streams;
using DigoFramework.Service;

namespace Ardrum.Service
{
    public class SrvPad : ServiceBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private int _intToqueVolume;
        private PanSource _objPanSource;
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
                if (_pad == value)
                {
                    return;
                }

                _pad = value;

                this.setPad(_pad);
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

        private PanSource objPanSource
        {
            get
            {
                if (_objPanSource != null)
                {
                    return _objPanSource;
                }

                _objPanSource = this.getObjPanSource();

                return _objPanSource;
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

            set
            {
                _objSoundOut = value;
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

            set
            {
                _objWave = value;
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

        private PanSource getObjPanSource()
        {
            PanSource objResultado = new PanSource(this.objWave.ToSampleSource());

            objResultado = new PanSource(this.objWave.ToSampleSource());

            return objResultado;
        }

        private ISoundOut getObjSoundOut()
        {
            if (this.pad == null)
            {
                return null;
            }

            if (AppArdrum.i.objDevice == null)
            {
                return null;
            }

            if (this.objWave == null)
            {
                return null;
            }

            ISoundOut objSoundOutResultado = new WasapiOut() { Latency = 25, Device = AppArdrum.i.objDevice };

            objSoundOutResultado.Initialize(this.objWave.ToSampleSource().ToWaveSource());

            objSoundOutResultado.Volume = this.pad.fltVolume;

            return objSoundOutResultado;
        }

        private IWaveSource getObjWave()
        {
            if (this.pad == null)
            {
                return null;
            }

            IWaveSource objWaveResultado = CodecFactory.Instance.GetCodec(this.pad.dirAudio)
                .ToSampleSource()
                .ToStereo()
                .AppendSource(x => new PanSource(x) { Pan = this.pad.fltBalanco }).ToWaveSource();

            return objWaveResultado;
        }

        private void loop()
        {
            this.tocar();
        }

        private void reiniciarObjWave()
        {
            this.objSoundOut = null;
            this.objWave = null;
        }

        private void setPad(PadDominio pad)
        {
            if (pad == null)
            {
                return;
            }

            pad.onDirAudioChanged += this.pad_onDirAudioChanged;
            pad.onFltBalancoChanged += this.pad_onFltBalancoChanged;
            pad.onFltVolumeChanged += this.pad_onFltVolumeChanged;
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

        private void pad_onDirAudioChanged(object sender, string dirAudio)
        {
            this.reiniciarObjWave();
        }

        private void pad_onFltBalancoChanged(object sender, float fltBalanco)
        {
            this.reiniciarObjWave();
        }

        private void pad_onFltVolumeChanged(object sender, float fltVolume)
        {
            this.objSoundOut.Volume = this.pad.fltVolume;
        }

        #endregion Eventos
    }
}