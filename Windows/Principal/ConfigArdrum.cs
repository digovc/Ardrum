using DigoFramework;

namespace Ardrum
{
    public class ConfigArdrum : ConfigBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static ConfigArdrum _i;

        private int _intSerialBaudRate = 9600;

        private string _strSerialPortName = "com3";

        public new static ConfigArdrum i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new ConfigArdrum();

                return _i;
            }
        }

        public int intSerialBaudRate
        {
            get
            {
                return _intSerialBaudRate;
            }

            set
            {
                _intSerialBaudRate = value;
            }
        }

        public string strSerialPortName
        {
            get
            {
                return _strSerialPortName;
            }

            set
            {
                _strSerialPortName = value;
            }
        }

        #endregion Atributos

        #region Construtores

        private ConfigArdrum()
        {
        }

        #endregion Construtores

        #region Métodos

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}