using DistribuidoraBebidas.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistribuidoraBebidas.ClasesDal
{
    class HistorialCompraDal
    {
        IList<Compra> historialCompras = new List<Compra>();
        Conexion miConexion = new Conexion();

        string CadenaConexion = "DATA SOURCE = DESKTOP-SNLMS6S\\PRIMERAGESTION; INITIAL CATALOG = dbDistribuidora; INTEGRATED SECURITY = True";
        public IList<Compra> TraerHistorial()
        {
            
            string consulta = "SELECT Id, Cliente, MontoCompra, FormaPago FROM HistorialCompras";
            try
            {
                using (SqlConnection miConexion =  new SqlConnection(CadenaConexion))
                {
                    miConexion.Open();

                    using (SqlCommand miComando = new SqlCommand(consulta, miConexion))
                    {
                        SqlDataReader miDataReader = miComando.ExecuteReader();

                        while (miDataReader.Read())
                        {
                            historialCompras.Add(new Compra(miDataReader["Cliente"].ToString(), float.Parse(miDataReader["MontoCompra"].ToString()), miDataReader["FormaPago"].ToString()));
                        }

                        return historialCompras;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        public void AgregarCompra(Compra nuevaCompra)
        {
            string consulta = $"INSERT into HistorialCompras(Cliente, MontoCompra, FormaPago) VALUES ('{nuevaCompra.NombreCliente}', {nuevaCompra.MontoPagar}, '{nuevaCompra.FormaPago}')";
            miConexion.Consultar(consulta, CadenaConexion);
        }




    }
}
