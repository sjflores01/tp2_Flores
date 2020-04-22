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

        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            Articulo articulo;
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.SetearQuery("SELECT a.Eliminado, a.Codigo, c.Descripcion as Categoria, m.Descripcion as Marca, a.Nombre, a.ImagenUrl, a.Precio, a.Id, m.Id, c.Id, a.Descripcion " +
                                      "from Articulos AS a " +
                                      "INNER JOIN Marcas as m ON a.IdMarca = m.Id " +
                                      "INNER JOIN Categorias as c ON a.IdCategoria = c.Id");
                datos.EjecutarLector();

                while (datos.lector.Read())
                {
                    articulo = new Articulo();
                    articulo.Eliminado = datos.lector.GetBoolean(0);
                    if (!articulo.Eliminado)
                    {
                        articulo.Id = datos.lector.GetInt32(7);
                        articulo.Codigo = datos.lector["Codigo"].ToString();
                        articulo.Marca = new Marca();
                        articulo.Marca.Id = datos.lector.GetInt32(8);
                        articulo.Marca.Descripcion = datos.lector["Marca"].ToString();
                        articulo.Categoria = new Categoria();
                        articulo.Categoria.Id = datos.lector.GetInt32(9);
                        articulo.Categoria.Descripcion = datos.lector["Categoria"].ToString();
                        articulo.Nombre = datos.lector["Nombre"].ToString();
                        articulo.Descripcion = datos.lector["Descripcion"].ToString();
                        articulo.Imagen = datos.lector["ImagenUrl"].ToString();
                        articulo.Precio = datos.lector.GetDecimal(6);

                        lista.Add(articulo);
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

        public void Alta(Articulo articulo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = "data source=DESKTOP-1CME8C0\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO ARTICULOS VALUES (@Codigo, @Nombre, @Descripcion, @Marca, @Categoria, @Imagen, @Precio, @Eliminado)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Codigo",articulo.Codigo);
                comando.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                comando.Parameters.AddWithValue("@Marca", articulo.Marca.Id);
                comando.Parameters.AddWithValue("@Categoria", articulo.Categoria.Id);
                comando.Parameters.AddWithValue("@Imagen", articulo.Imagen);
                comando.Parameters.AddWithValue("@Precio", articulo.Precio);
                comando.Parameters.AddWithValue("@Eliminado", articulo.Eliminado);
                conexion.Open();
                comando.ExecuteNonQuery();

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

        public void Baja(int Id)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.SetearQuery("UPDATE Articulos SET Eliminado = 1 WHERE Id = " + Id);
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

        public void Modificar(Articulo articulo)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.SetearQuery(" UPDATE Articulos SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion," +
                    "IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenURL = @Imagen, Precio = @Precio " +
                    "WHERE Id = @IdArticulo");
                datos.agregarParametros("@Codigo", articulo.Codigo);
                datos.agregarParametros("@Nombre", articulo.Nombre);
                datos.agregarParametros("@Descripcion", articulo.Descripcion);
                datos.agregarParametros("@IdMarca", articulo.Marca.Id);
                datos.agregarParametros("@IdCategoria", articulo.Categoria.Id);
                datos.agregarParametros("@Imagen", articulo.Imagen);
                datos.agregarParametros("@Precio", articulo.Precio);
                datos.agregarParametros("@IdArticulo", articulo.Id);
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
