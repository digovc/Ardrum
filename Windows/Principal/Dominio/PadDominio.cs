using System;

namespace Ardrum.Dominio
{
    public class PadDominio : ArdrumDominioBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private string _dirAudio;
        private float _fltVolume = 0.75f;
        private int _intPinoNumero;
        private string _strNome;

        public string dirAudio
        {
            get
            {
                return _dirAudio;
            }

            set
            {
                if (_dirAudio == value)
                {
                    return;
                }

                _dirAudio = value;

                this.setDirAudio(_dirAudio);
            }
        }

        public float fltVolume
        {
            get
            {
                return _fltVolume;
            }

            set
            {
                if (_fltVolume == value)
                {
                    return;
                }

                _fltVolume = value;

                this.setFltVolume(_fltVolume);
            }
        }

        public int intPinoNumero
        {
            get
            {
                return _intPinoNumero;
            }

            set
            {
                _intPinoNumero = value;
            }
        }

        public string strNome
        {
            get
            {
                return _strNome;
            }

            set
            {
                _strNome = value;
            }
        }

        #endregion Atributos

        #region Construtores

        #endregion Construtores

        #region Métodos

        private void setDirAudio(string dirAudio)
        {
            this.onDirAudioChanged?.Invoke(this, EventArgs.Empty);
        }

        private void setFltVolume(float decVolume)
        {
            this.onFltVolumeChanged?.Invoke(this, EventArgs.Empty);
        }

        #endregion Métodos

        #region Eventos

        public event EventHandler onDirAudioChanged;

        public event EventHandler onFltVolumeChanged;

        #endregion Eventos
    }
}