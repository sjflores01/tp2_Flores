using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDominio
{
    public class Marca
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Eliminado { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
