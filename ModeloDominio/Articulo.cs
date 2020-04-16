using System;
using System.Collections.Generic;

namespace ModeloDominio
{
    public class Articulo
    {
        #region Propiedades

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public string Imagen { get; set; }
        public double Precio { get; set; }
        public bool Eliminado { get; set; }

        #endregion

        #region Metodos

        public bool Alta ()
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
