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
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "SELECT Eliminado, Id, Descripcion from Marcas";
				conexion.Open();

				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					marca = new Marca();
					marca.Eliminado = lector.GetBoolean(0);
					if (!marca.Eliminado)
					{
						marca.Id = lector.GetInt32(1);
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

		public List<Marca> Listar()
		{
			AccesoADatos datos = new AccesoADatos();
			List<Marca> lista = new List<Marca>();
			Marca marca;
			try
			{
				datos.SetearQuery("SELECT Eliminado, Id, Descripcion FROM Marcas");
				datos.EjecutarLector();

				while (datos.lector.Read())
				{
					marca = new Marca();
					marca.Eliminado = datos.lector.GetBoolean(0);
					if (!marca.Eliminado)
					{
						marca.Id = datos.lector.GetInt32(1);
						marca.Descripcion = datos.lector["Descripcion"].ToString();
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
				datos.CerrarConexion();
			}
		}

		public void Alta(Marca marca)
		{
			AccesoADatos datos = new AccesoADatos();

			try
			{
				datos.SetearQuery("INSERT INTO Marcas VALUES (@Descripcion, @Eliminado)");
				datos.agregarParametros("@Descripcion", marca.Descripcion);
				datos.agregarParametros("@Eliminado", marca.Eliminado);
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
    }
}
