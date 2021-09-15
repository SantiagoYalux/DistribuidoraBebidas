using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DistribuidoraBebidas.Clases;

namespace DistribuidoraBebidas.ClasesDal
{
    class BebidaDal
    {        

       public List<Bebida> ObtenerBebidas(EventHandler eventoBotones, List<Bebida> bebidas)
        {
            
            try
            {
                using (SqlConnection miConexion = new SqlConnection("DATA SOURCE = DESKTOP-SNLMS6S\\PRIMERAGESTION; INITIAL CATALOG = dbDistribuidora; Integrated Security = True"))
                {
                    miConexion.Open();
                    
                    using (SqlCommand miComando = new SqlCommand("SELECT Nombre, Precio, Cantidad, Mililitros FROM Bebidas", miConexion))
                    {
                        SqlDataReader rd = miComando.ExecuteReader();

                        while (rd.Read())
                        {
                            bebidas.Add(new Bebida(rd["Nombre"].ToString(), float.Parse(rd["Precio"].ToString()), int.Parse(rd["Cantidad"].ToString()), float.Parse(rd["Mililitros"].ToString()), eventoBotones));
                        }

                        return bebidas;
                        
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo salio mal");
                return bebidas;
                
            }
            
        }

        public void disminuirCantidadBebida(String Nombre)
        {
            string consulta = $"UPDATE Bebidas SET Cantidad = Cantidad - 1 where Nombre = '{Nombre}';";
            try
            {
                using(SqlConnection miConexion = new SqlConnection("DATA SOURCE = DESKTOP-SNLMS6S\\PRIMERAGESTION; INITIAL CATALOG = dbDistribuidora; Integrated Security = True"))
                {
                    miConexion.Open();
                    using (SqlCommand miComando = new SqlCommand(consulta, miConexion))
                    {
                        miComando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
        }

        //ESTO LO USAREMOS CUANDO EL EMPLEADO ELIMINE DE LA LISTA ALGUNA BEBIDA
        public void aumentarCantidadBebidad(string Nombre)
        {
            string consulta = $"UPDATE Bebidas SET Cantidad = Cantidad + 1 where Nombre = '{Nombre}';";
            try
            {
                using (SqlConnection miConexion = new SqlConnection("DATA SOURCE = DESKTOP-SNLMS6S\\PRIMERAGESTION; INITIAL CATALOG = dbDistribuidora; Integrated Security = True"))
                {
                    miConexion.Open();
                    using (SqlCommand miComando = new SqlCommand(consulta, miConexion))
                    {
                        miComando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
        }
    }
}
