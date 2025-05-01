using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {

        public List<Articulo> listar()
        {

            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion DescMarca, C.Descripcion DescCategoria, ImagenUrl, A.IdMarca, A.IdCategoria, Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id and  A.IdCategoria= C.ID and Nombre is not null and Codigo <> '0'");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Cod = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    
                    aux.Compania = new Marcas();
                    aux.Compania.Id = (int)datos.Lector["IdMarca"];
                    aux.Compania.Descripcion = (string)datos.Lector["DescMarca"];

                    aux.Tipo = new Categorias();
                    aux.Tipo.Id = (int)datos.Lector["IdCategoria"];
                    aux.Tipo.Descripcion = (string)datos.Lector["DescCategoria"];

                    aux.Precio = (decimal)datos.Lector["Precio"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }
                return lista;
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

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                datos.setearParametro("@Codigo", nuevo.Cod);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Compania.Id);
                datos.setearParametro("@IdCategoria", nuevo.Tipo.Id);
                datos.setearParametro("@ImagenUrl", nuevo.UrlImagen);
                datos.setearParametro("@Precio", nuevo.Precio);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                Console.WriteLine($"Consulta generada: insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones) values ('{nuevo.Nombre}', '{nuevo.Cod}', {nuevo.Descripcion})");
            }
        }

        public void modificar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where Id = @Id");
                datos.setearParametro("@Id", nuevo.Id);
                datos.setearParametro("@Codigo", nuevo.Cod);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Compania.Id);
                datos.setearParametro("@IdCategoria", nuevo.Tipo.Id);
                datos.setearParametro("@ImagenUrl", nuevo.UrlImagen);
                datos.setearParametro("@Precio", nuevo.Precio);

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

        public void eliminar ( int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("DELETE from ARTICULOS where Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void eliminarLogico( int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = 0 where Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Articulo> filtrar (string columna, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos ();
            try 
            {
                string consulta = "select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion DescMarca, C.Descripcion DescCategoria, ImagenUrl, A.IdMarca, A.IdCategoria, Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id and  A.IdCategoria= C.ID and Nombre is not null and Codigo <> 0 and ";

                if(columna == "Nombre")
                {
                    if (criterio == "Comienza con")
                        consulta += "Nombre like '" + filtro + "%'";
                    else if (criterio == "Termina con")
                        consulta += "Nombre like '%" + filtro + "'";
                    else
                        consulta += "Nombre like '%" + filtro + "%'";
                }
                else if (columna == "Precio")
                {
                    if (criterio == "Mayor a")
                        consulta += "Precio > " + filtro;
                    else if (criterio == "Menor a")
                        consulta += "Precio < " + filtro;
                    else
                        consulta += "Precio = " + filtro;
                }
                else if (columna == "Descripcion")
                Console.WriteLine (consulta);
                datos.setearConsulta (consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Cod = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Compania = new Marcas();
                    aux.Compania.Id = (int)datos.Lector["IdMarca"];
                    aux.Compania.Descripcion = (string)datos.Lector["DescMarca"];

                    aux.Tipo = new Categorias();
                    aux.Tipo.Id = (int)datos.Lector["IdCategoria"];
                    aux.Tipo.Descripcion = (string)datos.Lector["DescCategoria"];

                    aux.Precio = (decimal)datos.Lector["Precio"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lista;
        }

    }
}
