using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDominio
{
    public class Marca
    {
        #region Propiedades

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Origen { get; set; }
        public bool Eliminado { get; set; }

        #endregion

        #region Metodos

        public bool Alta()
        {
            bool result = false;

            return result;
        }
        public bool Baja(int cod)
        {
            bool result = false;

            return result;
        }
        public bool Modificar(int cod)
        {
            bool result = false;

            return result;
        }

        #endregion
    }
}
