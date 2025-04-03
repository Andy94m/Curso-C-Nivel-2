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
                comando.CommandText = "select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Genero, T.Descripcion Formato from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id and  D.IdTipoEdicion = T.Id";
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
                    aux.Genero.Descripcion = (string)lector["Genero"];

                    aux.Formato = new Edicion();
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
                datos.setearConsulta("insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, IdEstilo, IdTipoEdicion) values (@Titulo, @FechaLanzamiento, @CantidadCanciones, @IdEstilo, @IdTipoEdicion)");
                datos.setearParametro("@Titulo", nuevo.Nombre);
                datos.setearParametro("@FechaLanzamiento", nuevo.Fecha);
                datos.setearParametro("@CantidadCanciones", nuevo.Canciones);
                datos.setearParametro("@IdEstilo", nuevo.Genero.Id);
                datos.setearParametro("@IdTipoEdicion", nuevo.Formato.Id);

                Console.WriteLine(nuevo.Formato.Id.ToString());
                Console.WriteLine(nuevo.Genero.Id.ToString());
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Console.WriteLine($"Consulta generada: insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones) values ('{nuevo.Nombre}', '{nuevo.Fecha.ToString("yyyy-MM-dd HH:mm:ss")}', {nuevo.Numero})");
            }
        }

        public void modificar(Album modificar)
        {

        }
    }
}
