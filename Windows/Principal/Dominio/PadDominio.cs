using System;

namespace Ardrum.Dominio
{
    public class PadDominio : ArdrumDominioBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private string _dirAudio;
        private float _fltBalanco;
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

        public float fltBalanco
        {
            get
            {
                return _fltBalanco;
            }

            set
            {
                if (_fltBalanco == value)
                {
                    return;
                }

                _fltBalanco = value;

                this.setFltBalanco(_fltBalanco);
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
            this.onDirAudioChanged?.Invoke(this, dirAudio);
        }

        private void setFltBalanco(float fltBalanco)
        {
            this.onFltBalancoChanged?.Invoke(this, fltBalanco);
        }

        private void setFltVolume(float fltVolume)
        {
            this.onFltVolumeChanged?.Invoke(this, fltVolume);
        }

        #endregion Métodos

        #region Eventos

        public event EventHandler<string> onDirAudioChanged;

        public event EventHandler<float> onFltBalancoChanged;

        public event EventHandler<float> onFltVolumeChanged;

        #endregion Eventos
    }
}