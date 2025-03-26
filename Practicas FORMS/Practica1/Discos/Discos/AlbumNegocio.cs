using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discos
{
    internal class AlbumNegocio
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
                comando.CommandText = "select D.Id, Titulo, CantidadCanciones, UrlImagenTapa, E.Descripcion Genero, T.Descripcion Formato from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id and  D.IdTipoEdicion = T.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Album aux = new Album();
                    aux.Numero = (int)lector["Id"];
                    aux.Nombre = (string)lector["Titulo"];
                    aux.Canciones = (int)lector["CantidadCanciones"];
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
    }
}
