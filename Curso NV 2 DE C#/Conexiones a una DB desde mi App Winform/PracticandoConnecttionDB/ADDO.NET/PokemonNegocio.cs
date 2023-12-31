using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Data;
using System.Security.Permissions;

namespace ADDO.NET
{
    internal class PokemonNegocio
    {
        public List <Pokemon> Listar()
        {
            List<Pokemon> ListaPokemones = new List<Pokemon>();

            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();

            SqlDataReader lector;



            try
            {
                
               conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
               comando.CommandType= System.Data.CommandType.Text;

               comando.CommandText= "Select Numero, Nombre, Descripcion,UrlImagen from POKEMONS";

                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while( lector.Read())
                {
                 Pokemon Auxiliar = new Pokemon();

                    Auxiliar.Nombre = (string)lector["Nombre"];
                    Auxiliar.Numero = (int)lector["Numero"];
                    Auxiliar.Descripcion = (string)lector["Descripcion"];
                    Auxiliar.UrilImagen = (string)lector["UrlImagen"];

                    ListaPokemones.Add(Auxiliar);

                }


                conexion.Close();




                return ListaPokemones;
            }
            catch (Exception ex)
            {

                throw;
            }
         

        }

     





    }
}