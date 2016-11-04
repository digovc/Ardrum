using System;
using System.ComponentModel;
using System.Windows.Forms;
using Ardrum.Controle;
using Ardrum.Dominio;
using Ardrum.Service;
using DigoFramework;

namespace Ardrum.Frm
{
    public partial class FrmPrincipal : FrmArdrumBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        #endregion Atributos

        #region Construtores

        public FrmPrincipal()
        {
            this.InitializeComponent();
        }

        #endregion Construtores

        #region Métodos

        protected override void inicializar()
        {
            base.inicializar();

            this.mxcMaster.fltVolume = ConfigArdrum.i.fltMasterVolume;
        }

        protected override void montarLayout()
        {
            base.montarLayout();

            this.montarLayoutLstPad();
        }

        protected override void setEventos()
        {
            base.setEventos();

            SrvArduino.i.onEnmStatusChanged += this.Arduino_onEnmStatusChanged;
        }

        private void atualizarSerialStatus()
        {
            switch (SrvArduino.i.enmStatus)
            {
                case SrvArduino.EnmStatus.CONECTADO:
                    this.btnConectar.strTitulo = "Desconectar";
                    this.lblArduinoStatus.Text = "Conectado";
                    return;

                case SrvArduino.EnmStatus.ERRO:
                    this.btnConectar.strTitulo = "Conectar";
                    this.lblArduinoStatus.Text = "Erro";
                    return;

                default:
                    this.btnConectar.strTitulo = "Conectar";
                    this.lblArduinoStatus.Text = "Desconectado";
                    return;
            }
        }

        private void conectar()
        {
            if (!SrvArduino.EnmStatus.CONECTADO.Equals(SrvArduino.i.enmStatus))
            {
                SrvArduino.i.iniciar();
                return;
            }

            SrvArduino.i.parar();
        }

        private void montarLayoutLstPad()
        {
            foreach (PadDominio pad in AppArdrum.i.lstPad)
            {
                this.montarLayoutLstPad(pad);
            }
        }

        private void montarLayoutLstPad(PadDominio pad)
        {
            if (pad == null)
            {
                return;
            }

            MixerCanal ctrMixerCanal = new MixerCanal();

            ctrMixerCanal.pad = pad;
            ctrMixerCanal.Dock = DockStyle.Right;

            this.pnlMixer.Controls.Add(ctrMixerCanal);
        }

        private void processarOnClosing()
        {
            this.pararServico();
            this.salvarConfig();
        }

        private void pararServico()
        {
            AppArdrum.i.pararServico();
        }

        private void salvarConfig()
        {
            ConfigArdrum.i.fltMasterVolume = this.mxcMaster.fltVolume;

            ConfigArdrum.i.salvar();
        }

        #endregion Métodos

        #region Eventos

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            try
            {
                this.processarOnClosing();
            }
            catch (Exception ex)
            {
                new Erro("Erro inesperado.\n", ex);
            }
        }

        private void Arduino_onEnmStatusChanged(object sender, SrvArduino.EnmStatus enmStatus)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.atualizarSerialStatus();
                });
            }
            catch (Exception ex)
            {
                new Erro("Erro inesperado.\n", ex);
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                this.conectar();
            }
            catch (Exception ex)
            {
                new Erro("Erro inesperado.\n", ex);
            }
        }

        #endregion Eventos
    }
}