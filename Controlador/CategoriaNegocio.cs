using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class CategoriaNegocio
    {
        #region Metodos

        public List<Categoria> Listar()
        {
            AccesoADatos datos = new AccesoADatos();
            List<Categoria> lista = new List<Categoria>();
            Categoria categoria;

            try
            {
                datos.SetearQuery("SELECT Eliminado, Id, Descripcion from Categorias");
                datos.EjecutarLector();

                while (datos.lector.Read())
                {
                    categoria = new Categoria();
                    categoria.Eliminado = datos.lector.GetBoolean(0);
                    if (!categoria.Eliminado)
                    {
                        categoria.Id = datos.lector.GetInt32(1);
                        categoria.Descripcion = datos.lector["Descripcion"].ToString();
                        lista.Add(categoria);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void Alta(Categoria categoria)
        {
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.SetearQuery("INSERT INTO CATEGORIAS VALUES(@Descripcion, @Eliminado)");
                datos.agregarParametros("@Descripcion", categoria.Descripcion);
                datos.agregarParametros("@Eliminado", categoria.Eliminado);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public bool BuscarCategoria(string nombre)
        {
            bool result = false;
            List<Categoria> lista;

            lista = Listar();

            foreach (Categoria categoria in lista)
            {
                if(nombre == categoria.Descripcion.ToLower())
                {
                    result = true;
                    return result;
                }
            }
            return result;
        }

        #endregion
    }
}
