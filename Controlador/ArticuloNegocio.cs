using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> ListarArticulos()
        {
            List<Articulo> listado = new List<Articulo>();
            Articulo articulo;
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source=DESKTOP-1CME8C0\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select a.Eliminado, a.Codigo, m.Descripcion as Marca, a.Nombre, a.ImagenUrl " +
                                      "from Articulos as a, Marcas as m where a.IdMarca = m.Id";
                comando.Connection = conexion;
                conexion.Open();

                lector = comando.ExecuteReader();
                
                while (lector.Read())
                {
                    articulo = new Articulo();
                    articulo.Eliminado = lector.GetBoolean(0);
                    if (!articulo.Eliminado)
                    {
                    articulo.Codigo = lector["Codigo"].ToString();
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = lector["Marca"].ToString();
                    articulo.Nombre = lector["Nombre"].ToString();
                    articulo.Imagen = lector["ImagenUrl"].ToString();

                    listado.Add(articulo);
                    }
                }

                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Alta(Articulo articulo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = "data source=DESKTOP-1CME8C0\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO ARTICULOS VALUES (" + articulo.Codigo + ", " + articulo.Nombre + ", " + articulo.Descripcion +
                                      ", " + articulo.Marca.Id + ", " + articulo.Categoria.Id + ", " + articulo.Imagen + ", " + articulo.Precio + ")";
                conexion.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public bool Baja(Articulo articulo)
        {
            bool result = false;

            return result;
        }

        public bool Modificar(Articulo articulo)
        {
            bool result = false;

            return result;
        }

        public bool BuscarCodigo(int codigo)
        {
            bool result = false;

            return result;
        }
    }
}
