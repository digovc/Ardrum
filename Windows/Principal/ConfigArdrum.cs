using DigoFramework;
using DigoFramework.Json;

namespace Ardrum
{
    public class ConfigArdrum : ConfigBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static ConfigArdrum _i;

        private float _fltMasterVolume = 0.75f;
        private int _intSerialBaudRate = 9600;
        private string _jsnLstPad;
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

        public float fltMasterVolume
        {
            get
            {
                return _fltMasterVolume;
            }

            set
            {
                _fltMasterVolume = value;
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

        public string jsnLstPad
        {
            get
            {
                return _jsnLstPad;
            }

            set
            {
                _jsnLstPad = value;
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

        public override void salvar()
        {
            this.jsnLstPad = Json.i.toJson(AppArdrum.i.lstPad);

            base.salvar();
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}