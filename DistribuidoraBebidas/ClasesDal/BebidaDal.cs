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
        Conexion miConexionBaseDatos = new Conexion();
        string cadenaConexion = "DATA SOURCE = DESKTOP-SNLMS6S\\PRIMERAGESTION; INITIAL CATALOG = dbDistribuidora; Integrated Security = True";

       public List<Bebida> ObtenerBebidas(EventHandler eventoBotones , List<Bebida> bebidas)
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
                MessageBox.Show("Algo salio mal", e.Message);
                return bebidas;
                
            }
            
        }




        //ESTO LO USAREMOS CUANDO EL CLIENTE ELIGE UNA BEBIDA, EL STOCK EN LA BASE DE DATOS DE LA BEBIDA ELEGIDA DEBE DISMINUIR EN 1
        public void disminuirCantidadBebida(String Nombre)
        {
            string consulta = $"UPDATE Bebidas SET Cantidad = Cantidad - 1 where Nombre = '{Nombre}';";

            miConexionBaseDatos.Consultar(consulta, cadenaConexion);
        }



        //ESTO LO USAREMOS CUANDO EL EMPLEADO ELIMINE DE LA LISTA ALGUNA BEBIDA, EL STOCK EN LA BASE DE DATOS DEBE AUMENTAR EN 1
        public void aumentarCantidadBebidad(string Nombre)
        {
            string consulta = $"UPDATE Bebidas SET Cantidad = Cantidad + 1 where Nombre = '{Nombre}';";

            miConexionBaseDatos.Consultar(consulta, cadenaConexion);
        }

        //EL EMPLEADO AGREGA BEBIDAS DESDE EL FORMULARIO
        public void AgregarBebida(string Nombre, int Cantidad, int Mililitros, float Precio)
        {
            string consulta = $"INSERT into Bebidas (Nombre, Cantidad, Mililitros, Precio) VALUES ('{Nombre}', {Cantidad}, {Mililitros}, {Precio})";

            miConexionBaseDatos.Consultar(consulta, cadenaConexion);
        }

        
    }
}
