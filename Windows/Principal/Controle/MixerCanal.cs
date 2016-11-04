using System;
using System.ComponentModel;
using System.Drawing;
using Ardrum.Dominio;
using DigoFramework;

namespace Ardrum.Controle
{
    public partial class MixerCanal : UserControlArdrumBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private bool _booLinhaDireita;
        private PadDominio _pad;
        private string _strTitulo = "Canal ???";

        [DisplayName("Linha lateral")]
        public bool booLinhaDireita
        {
            get
            {
                return _booLinhaDireita;
            }

            set
            {
                if (_booLinhaDireita == value)
                {
                    return;
                }

                _booLinhaDireita = value;

                this.setBooLinhaDireita(_booLinhaDireita);
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Size Size
        {
            get
            {
                return base.Size;
            }

            private set
            {
                base.Size = value;
            }
        }

        [DisplayName("Título")]
        public string strTitulo
        {
            get
            {
                return _strTitulo;
            }

            set
            {
                if (_strTitulo == value)
                {
                    return;
                }

                _strTitulo = value;

                this.setStrTitulo(_strTitulo);
            }
        }

        #endregion Atributos

        #region Construtores

        public MixerCanal()
        {
            this.InitializeComponent();
        }

        #endregion Construtores

        #region Métodos

        protected override void inicializar()
        {
            base.inicializar();

            this.Size = new Size(60, 200);
        }

        private void atualizarVolume()
        {
            if (this.pad == null)
            {
                return;
            }

            this.pad.fltVolume = (this.tcbVolume.Value / this.tcbVolume.Maximum);
        }

        private void setBooLinhaDireita(bool booLinhaDireita)
        {
            this.ctrLinha.Dock = booLinhaDireita ? System.Windows.Forms.DockStyle.Right : System.Windows.Forms.DockStyle.Left;
        }

        private void setPad(PadDominio pad)
        {
            if (pad == null)
            {
                return;
            }

            this.strTitulo = pad.strNome;
            this.tcbVolume.Value = (int)(pad.fltVolume * this.tcbVolume.Value);
        }

        private void setStrTitulo(string strTitulo)
        {
            this.lblTitulo.Text = strTitulo;
        }

        #endregion Métodos

        #region Eventos

        private void tcbVolume_Scroll(object sender, System.EventArgs e)
        {
            try
            {
                this.atualizarVolume();
            }
            catch (Exception ex)
            {
                new Erro("Erro inesperado.\n", ex);
            }
        }

        #endregion Eventos
    }
}