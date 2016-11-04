using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Ardrum.Dominio;
using CSCore.Codecs;
using DigoFramework;

namespace Ardrum.Controle
{
    public partial class MixerCanal : UserControlArdrumBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private bool _booControlarBalanco = true;
        private bool _booLinhaDireita;
        private bool _booMostrarComando = true;
        private float _fltVolume;
        private PadDominio _pad;
        private string _strTitulo = "Canal ???";

        [DisplayName("Controlar balanço")]
        public bool booControlarBalanco
        {
            get
            {
                return _booControlarBalanco;
            }

            set
            {
                if (_booControlarBalanco == value)
                {
                    return;
                }

                _booControlarBalanco = value;

                this.setBooControlarBalanco(_booControlarBalanco);
            }
        }

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

        [DisplayName("Mostrar comando")]
        public bool booMostrarComando
        {
            get
            {
                return _booMostrarComando;
            }

            set
            {
                if (_booMostrarComando == value)
                {
                    return;
                }

                _booMostrarComando = value;

                this.setBooMostrarComando(_booMostrarComando);
            }
        }

        [DisplayName("Volume")]
        public float fltVolume
        {
            get
            {
                _fltVolume = this.getFltVolume();

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

            this.ofdDirAudio.Filter = CodecFactory.SupportedFilesFilterEn;
        }

        private void atualizarDirAudio()
        {
            if (this.pad == null)
            {
                return;
            }

            this.ofdDirAudio.FileName = this.pad.dirAudio;

            if (!DialogResult.OK.Equals(this.ofdDirAudio.ShowDialog()))
            {
                return;
            }

            this.pad.dirAudio = this.ofdDirAudio.FileName;
        }

        private void atualizarFltBalanco()
        {
            if (this.pad == null)
            {
                return;
            }

            this.pad.fltBalanco = ((float)this.tcbBalanco.Value / (float)this.tcbBalanco.Maximum * 2 - 1);
        }

        private void atualizarVolume()
        {
            if (this.pad == null)
            {
                return;
            }

            this.pad.fltVolume = this.fltVolume;

            this.onFltVolumeChanged?.Invoke(this, this.fltVolume);
        }

        private float getFltVolume()
        {
            return ((float)this.tcbVolume.Value / (float)this.tcbVolume.Maximum);
        }

        private void setBooControlarBalanco(bool booControlarBalanco)
        {
            this.tcbBalanco.Visible = booControlarBalanco;
        }

        private void setBooLinhaDireita(bool booLinhaDireita)
        {
            this.ctrLinha.Dock = booLinhaDireita ? DockStyle.Right : DockStyle.Left;
        }

        private void setBooMostrarComando(bool booMostrarComando)
        {
            this.pnlComando.Visible = booMostrarComando;
        }

        private void setFltVolume(float fltVolume)
        {
            this.tcbVolume.Value = (int)(fltVolume * this.tcbVolume.Maximum);
        }

        private void setPad(PadDominio pad)
        {
            if (pad == null)
            {
                return;
            }

            this.strTitulo = pad.strNome;

            this.tcbBalanco.Value = (int)Math.Round((pad.fltBalanco + 2) * (this.tcbBalanco.Maximum / 2) - 5);

            this.tcbVolume.Value = (int)(pad.fltVolume * this.tcbVolume.Maximum);
        }

        private void setStrTitulo(string strTitulo)
        {
            this.lblTitulo.Text = strTitulo;
        }

        #endregion Métodos

        #region Eventos

        private void btnAudio_Click(object sender, EventArgs e)
        {
            try
            {
                this.atualizarDirAudio();
            }
            catch (Exception ex)
            {
                new Erro("Erro inesperado.\n", ex);
            }
        }

        private void tcbBalanco_Scroll(object sender, EventArgs e)
        {
            try
            {
                this.atualizarFltBalanco();
            }
            catch (Exception ex)
            {
                new Erro("Erro inesperado.\n", ex);
            }
        }

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

        public event EventHandler<float> onFltVolumeChanged;

        #endregion Eventos
    }
}