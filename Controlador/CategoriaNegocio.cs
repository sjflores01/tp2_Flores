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
        public List<Categoria> ListarCartegorias()
        {
            List<Categoria> lista = new List<Categoria>();
            Categoria categoria;
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source = DESKTOP-1CME8C0\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Eliminado, Id, Descripcion from Categorias";
                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    categoria = new Categoria();
                    categoria.Eliminado = lector.GetBoolean(0);
                    if (!categoria.Eliminado)
                    {
                        categoria.Id = lector.GetInt32(1);
                        categoria.Descripcion = lector["Descripcion"].ToString();
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
                conexion.Close();
            }
        }
    }
}
