﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=localhost; database=POKEDEX_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad from POKEMONS P, ELEMENTOS E, ELEMENTOS D where E.Id = P.IdTipo and D.Id = P.IdDebilidad";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["UrlImagen"];

                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

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

        public void agregar(Pokemon nuevo)
        {

        }

        public void modificar(Pokemon modificar)
        {

        }
    }

    
}
