using System;
using System.IO.Ports;
using System.Threading;
using DigoFramework.Service;

namespace Ardrum.Service
{
    public class SrvArduino : ServiceBase
    {
        #region Constantes

        public enum EnmStatus
        {
            CONECTADO,
            DESCONECTADO,
            ERRO,
            NONE,
        }

        #endregion Constantes

        #region Atributos

        private static SrvArduino _i;

        private EnmStatus _enmStatus = EnmStatus.NONE;
        private SerialPort _objSerial;

        public static SrvArduino i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new SrvArduino();

                return _i;
            }
        }

        public EnmStatus enmStatus
        {
            get
            {
                return _enmStatus;
            }

            private set
            {
                if (_enmStatus == value)
                {
                    return;
                }

                _enmStatus = value;

                this.setEnmStatus(_enmStatus);
            }
        }

        private SerialPort objSerial
        {
            get
            {
                if (_objSerial != null)
                {
                    return _objSerial;
                }

                _objSerial = this.getObjSerial();

                return _objSerial;
            }
        }

        #endregion Atributos

        #region Construtores

        private SrvArduino() : base("Arduino Serial Server")
        {
        }

        #endregion Construtores

        #region Métodos

        protected override void servico()
        {
            this.conectar();

            while (!this.booParar && this.objSerial.IsOpen)
            {
                this.loop();
                Thread.Sleep(1);
            }

            this.desconectar();
        }

        private void conectar()
        {
            if (this.objSerial.IsOpen)
            {
                return;
            }

            try
            {
                this.objSerial.Open();
                this.enmStatus = EnmStatus.CONECTADO;
            }
            catch (Exception)
            {
                this.enmStatus = EnmStatus.ERRO;
            }
        }

        public override void parar()
        {
            base.parar();

            this.desconectar();
        }

        private void desconectar()
        {
            this.objSerial.Close();

            this.enmStatus = EnmStatus.DESCONECTADO;
        }

        private void enviar()
        {
        }

        private SerialPort getObjSerial()
        {
            SerialPort objSerialResultado = new SerialPort();

            objSerialResultado.BaudRate = ConfigArdrum.i.intSerialBaudRate;
            objSerialResultado.PortName = ConfigArdrum.i.strSerialPortName;

            return objSerialResultado;
        }

        private void loop()
        {
            this.enviar();
            this.receber();
        }

        private void receber()
        {
            if (!this.objSerial.IsOpen)
            {
                return;
            }

            this.receber(this.objSerial.ReadLine());
        }

        private void receber(string strBuffer)
        {
            if (string.IsNullOrEmpty(strBuffer))
            {
                return;
            }

            if (strBuffer.Length < 2)
            {
                return;
            }

            int intPinoNumero = (int)char.GetNumericValue(strBuffer[0]);
            int intToqueVolume = (int)char.GetNumericValue(strBuffer[1]);

            AppArdrum.i.tocar(intPinoNumero, intToqueVolume);
        }

        private void setEnmStatus(EnmStatus enmStatus)
        {
            this.onEnmStatusChanged?.Invoke(this, EventArgs.Empty);
        }

        #endregion Métodos

        #region Eventos

        public event EventHandler onEnmStatusChanged;

        #endregion Eventos
    }
}