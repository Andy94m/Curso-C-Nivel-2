using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    internal class AccesoDatos
    {
        //Se declaran los atributos de tipo Sql
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        //Si bien lector es privado, se expone un acceso get que retorna el valor del atributo a leer
        public SqlDataReader Lector 
        { 
            get{ return lector; }
        }

        //Constructor de la clase,instancia la conexion SQL de forma local con autenticación de windows
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRES; database=CATALOGO_DB; integrated securty=true");
            comando = new SqlCommand();
        }

        //setea el tipo de comando y se pasa por parametro el string
        public void setearConsultar(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        //Ejecuta la query y lee los datos devueltos -> SELECT
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //solo ejecuta query, no tiene datos de retorno-> insert, update o delete.
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Evalua si lector se instanció y cierra la conexión.
        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

    }
}
