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
    }
}
