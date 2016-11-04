using System.ComponentModel;

namespace Ardrum.Controle
{
    public partial class BotaoArdrum : UserControlArdrumBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private string _strTitulo;

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

        public BotaoArdrum()
        {
            this.InitializeComponent();
        }

        #endregion Construtores

        #region Métodos

        private void setStrTitulo(string strTitulo)
        {
            this.btn.Text = strTitulo;
        }

        #endregion Métodos

        #region Eventos

        private void btn_Click(object sender, System.EventArgs e)
        {
            this.InvokeOnClick(this, e);
        }

        #endregion Eventos
    }
}