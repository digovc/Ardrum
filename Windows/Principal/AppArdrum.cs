using System;
using System.Collections.Generic;
using Ardrum.Dominio;
using Ardrum.Service;
using CSCore.CoreAudioAPI;
using DigoFramework;

namespace Ardrum
{
    public class AppArdrum : AppBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static AppArdrum _i;

        private List<PadDominio> _lstPad;
        private List<SrvPad> _lstSrvPad;

        private MMDevice _objDevice;

        public new static AppArdrum i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new AppArdrum();

                return _i;
            }
        }

        public List<PadDominio> lstPad
        {
            get
            {
                if (_lstPad != null)
                {
                    return _lstPad;
                }

                _lstPad = this.getLstPad();

                return _lstPad;
            }
        }

        public MMDevice objDevice
        {
            get
            {
                if (_objDevice != null)
                {
                    return _objDevice;
                }

                _objDevice = this.getObjDevice();

                return _objDevice;
            }
        }

        private List<SrvPad> lstSrvPad
        {
            get
            {
                if (_lstSrvPad != null)
                {
                    return _lstSrvPad;
                }

                _lstSrvPad = this.getLstSrvPad();

                return _lstSrvPad;
            }
        }

        #endregion Atributos

        #region Construtores

        private AppArdrum() : base("Ardrum")
        {
        }

        #endregion Construtores

        #region Métodos

        internal void tocar(int intPinoNumero, int intToqueVolume)
        {
            if (intPinoNumero < 0)
            {
                return;
            }

            if (intToqueVolume < 1)
            {
                return;
            }

            foreach (SrvPad srvPad in this.lstSrvPad)
            {
                if (this.tocar(intPinoNumero, intToqueVolume, srvPad))
                {
                    return;
                }
            }
        }

        protected override Type getClsFrmPrincipal()
        {
            return typeof(Frm.FrmPrincipal);
        }

        private List<PadDominio> getLstPad()
        {
            List<PadDominio> lstPadResultado = new List<PadDominio>();

            lstPadResultado.Add(new PadDominio() { strNome = "Chimbal", dirAudio = "hi-hat.wav", intPinoNumero = 0 });
            lstPadResultado.Add(new PadDominio() { strNome = "Tarol", dirAudio = "snare.wav", intPinoNumero = 1 });
            //lstPadResultado.Add(new PadDominio() { strNome = "Bumbo" });
            //lstPadResultado.Add(new PadDominio() { strNome = "Tom A" });
            //lstPadResultado.Add(new PadDominio() { strNome = "Tom B" });
            //lstPadResultado.Add(new PadDominio() { strNome = "Surdo" });
            //lstPadResultado.Add(new PadDominio() { strNome = "Prato condução" });
            //lstPadResultado.Add(new PadDominio() { strNome = "Prato ataque" });

            return lstPadResultado;
        }

        private List<SrvPad> getLstSrvPad()
        {
            List<SrvPad> lstSrvPadResultado = new List<SrvPad>();

            foreach (PadDominio pad in this.lstPad)
            {
                this.getLstSrvPad(lstSrvPadResultado, pad);
            }

            return lstSrvPadResultado;
        }

        private void getLstSrvPad(List<SrvPad> lstSrvPad, PadDominio pad)
        {
            SrvPad srvPad = new SrvPad(pad);

            srvPad.iniciar();

            lstSrvPad.Add(srvPad);
        }

        private MMDevice getObjDevice()
        {
            using (var objMMDeviceEnumerator = new MMDeviceEnumerator())
            using (var objMMDeviceCollection = objMMDeviceEnumerator.EnumAudioEndpoints(DataFlow.Render, DeviceState.Active))
            {
                foreach (var objDevice in objMMDeviceCollection)
                {
                    return objDevice;
                }
            }

            return null;
        }

        private bool tocar(int intPinoNumero, int intToqueVolume, SrvPad srvPad)
        {
            if (!intPinoNumero.Equals(srvPad.pad.intPinoNumero))
            {
                return false;
            }

            srvPad.tocar(intToqueVolume);

            return true;
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}