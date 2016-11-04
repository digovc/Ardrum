using DigoFramework.Json;
using Newtonsoft.Json;

namespace Ardrum
{
    public class JsonArdrum : Json
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static JsonArdrum _i;

        public new static JsonArdrum i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new JsonArdrum();

                return _i;
            }
        }

        #endregion Atributos

        #region Construtores

        private JsonArdrum()
        {
        }

        #endregion Construtores

        #region Métodos

        protected override JsonSerializerSettings getCfg()
        {
            JsonSerializerSettings objResultado = base.getCfg();

            objResultado.TypeNameHandling = TypeNameHandling.All;

            return objResultado;
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}