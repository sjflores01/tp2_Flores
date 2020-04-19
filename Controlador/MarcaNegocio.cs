using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> ListarMarcas()
        {
			List<Marca> lista = new List<Marca>();
			Marca marca;
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;

			try
			{

				conexion.ConnectionString = "data source=DESKTOP-1CME8C0\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi ";
				comando.Connection = conexion;
				comando.CommandText = "SELECT Eliminado, Descripcion from Marcas";
				conexion.Open();

				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					marca = new Marca();
					marca.Eliminado = lector.GetBoolean(0);
					if (!marca.Eliminado)
					{
						marca.Descripcion = lector["Descripcion"].ToString();
					}
					lista.Add(marca);
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
