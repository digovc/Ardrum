using System.ComponentModel;
using System.Drawing;

namespace Ardrum.Controle
{
    public partial class MixerCanal : UserControlArdrumBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private bool _booLinhaDireita;
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
            InitializeComponent();
        }

        #endregion Construtores

        #region Métodos

        private void setBooLinhaDireita(bool booLinhaDireita)
        {
            this.ctrLinha.Dock = booLinhaDireita ? System.Windows.Forms.DockStyle.Right : System.Windows.Forms.DockStyle.Left;
        }

        private void setStrTitulo(string strTitulo)
        {
            this.lblTitulo.Text = strTitulo;
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}