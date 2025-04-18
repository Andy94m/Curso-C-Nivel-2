using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using dominio;

namespace negocio
{
    public class AlbumNegocio
    {
        public List<Album> listar()
        {
            List<Album> lista = new List<Album>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            
            try
            {
                conexion.ConnectionString = "server=localhost; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Genero, T.Descripcion Formato, D.IdEstilo, D.IdTipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id and  D.IdTipoEdicion = T.Id and D.CantidadCanciones != 0";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Album aux = new Album();
                    aux.Numero = (int)lector["Id"];
                    aux.Nombre = (string)lector["Titulo"];
                    aux.Fecha = (DateTime)lector["FechaLanzamiento"];
                    aux.Canciones = (int)lector["CantidadCanciones"];

                    if (!(lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagen = (string)lector["UrlImagenTapa"];

                    aux.Genero = new Estilos();
                    aux.Genero.Id = (int)lector["IdEstilo"];
                    aux.Genero.Descripcion = (string)lector["Genero"];

                    aux.Formato = new Edicion();
                    aux.Formato.Id = (int)lector["IdTipoEdicion"];
                    aux.Formato.Descripcion = (string)lector["Formato"];

                    
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(Album nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            Console.WriteLine($"Consulta SQL: INSERT INTO DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, IdTipoEdicion, IdEstilo) " +
                  $"VALUES ('{nuevo.Nombre}', '{nuevo.Fecha}', {nuevo.Canciones}, {nuevo.Formato.Id}, {nuevo.Genero.Id})");
            try
            {
                datos.setearConsulta("insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion) values (@Titulo, @FechaLanzamiento, @CantidadCanciones, @UrlImagenTapa, @IdEstilo, @IdTipoEdicion)");
                datos.setearParametro("@Titulo", nuevo.Nombre);
                datos.setearParametro("@FechaLanzamiento", nuevo.Fecha);
                datos.setearParametro("@CantidadCanciones", nuevo.Canciones);
                datos.setearParametro("@UrlImagenTapa", nuevo.UrlImagen);
                datos.setearParametro("@IdEstilo", nuevo.Genero.Id);
                datos.setearParametro("@IdTipoEdicion", nuevo.Formato.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                Console.WriteLine($"Consulta generada: insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones) values ('{nuevo.Nombre}', '{nuevo.Fecha.ToString("yyyy-MM-dd HH:mm:ss")}', {nuevo.Numero})");
            }
        }

        public void modificar(Album album)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update DISCOS set Titulo = @Nombre, FechaLanzamiento = @Fecha, CantidadCanciones = @Canciones, UrlImagenTapa = @UrlImagen, IdEstilo = @IdEstilo, IdTipoEdicion = @IdTipoEdicion where Id = @Id");
                datos.setearParametro("@Id", album.Numero);
                datos.setearParametro("@Nombre", album.Nombre);
                datos.setearParametro("@Fecha", album.Fecha);
                datos.setearParametro("@Canciones", album.Canciones);
                datos.setearParametro("@UrlImagen", album.UrlImagen);
                datos.setearParametro("@IdEstilo", album.Genero.Id);
                datos.setearParametro("@IdTipoEdicion", album.Formato.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar (int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("DELETE from DISCOS where Id = @Id");
                datos.setearParametro("@Id",id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void eliminarLogico(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE DISCOS set CantidadCanciones = 0 where Id = @id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Album> filtrar (string campo, string criterio, string filtro)
        {
            List<Album> lista = new List<Album>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Genero, T.Descripcion Formato, D.IdEstilo, D.IdTipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id and  D.IdTipoEdicion = T.Id and D.CantidadCanciones != 0 and ";
                if(campo == "Nombre")
                {
                    Console.WriteLine("Dentro de nombre");
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Titulo like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "Titulo like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Titulo like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Año")
                {
                    Console.WriteLine("Dentro de año");
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "YEAR(FechaLanzamiento) > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "YEAR(FechaLanzamiento) < " + filtro;
                            break;
                        default:
                            consulta += "YEAR(FechaLanzamiento) = " + filtro;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Dentro de cantidad canciones");
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "CantidadCanciones > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "CantidadCanciones < " + filtro;
                            break;
                        default:
                            consulta += "CantidadCanciones = " + filtro;
                            break;
                    }
                }
                Console.WriteLine(consulta);
                datos.setearConsulta( consulta );
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Album aux = new Album();
                    aux.Numero = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Titulo"];
                    aux.Fecha = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.Canciones = (int)datos.Lector["CantidadCanciones"];

                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["UrlImagenTapa"];

                    aux.Genero = new Estilos();
                    aux.Genero.Id = (int)datos.Lector["IdEstilo"];
                    aux.Genero.Descripcion = (string)datos.Lector["Genero"];

                    aux.Formato = new Edicion();
                    aux.Formato.Id = (int)datos.Lector["IdTipoEdicion"];
                    aux.Formato.Descripcion = (string)datos.Lector["Formato"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
