namespace Ardrum.Dominio
{
    public class PadDominio : ArdrumDominioBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private string _dirAudio;
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
                _dirAudio = value;
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

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}