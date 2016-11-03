using System;
using DigoFramework;

namespace Ardrum
{
    public class AppArdrum : AppBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static AppArdrum _i;

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

        #endregion Atributos

        #region Construtores

        private AppArdrum() : base("Ardrum")
        {
        }

        #endregion Construtores

        #region Métodos

        protected override Type getClsFrmPrincipal()
        {
            return typeof(Frm.FrmPrincipal);
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}