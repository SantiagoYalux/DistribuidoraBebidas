using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistribuidoraBebidas.Clases
{
    public class Conexion
    {
        string cadenaConexion { get; set; }
        string consultas { get; set; }

        //Updsate, insert, delete
        public bool Consultar(string consulta, string cadenaConexion)
        {
            var result = false;

            try
            {
                using (SqlConnection miConexion = new SqlConnection(cadenaConexion))
                {
                    miConexion.Open();
                    using (SqlCommand miComando = new SqlCommand(consulta, miConexion))
                    {
                        miComando.ExecuteNonQuery();
                        result = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo salio mal", e.Message);
                throw;
            }
            
           

            return result;
            
        }

       public IList<Bebida> consultaListas(string consulta, string cadenaConexion, IList<Bebida> bebidasBaseDatos)
        {

            using (SqlConnection miConexion = new SqlConnection(cadenaConexion))
            {
                miConexion.Open();

                using (SqlCommand miComando = new SqlCommand(consulta, miConexion))
                {
                    SqlDataReader miReader = miComando.ExecuteReader();

                    while (miReader.Read())
                    {
                      
                    }

                }
               
            }

            return bebidasBaseDatos;
        }

    }
}
