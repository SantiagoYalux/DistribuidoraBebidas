using DistribuidoraBebidas.Clases;
using DistribuidoraBebidas.ClasesDal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistribuidoraBebidas.Formularios
{
    public partial class RegistroVentas : Form
    {
        public IList<Compra> listaCompras = new List<Compra>();

        public List<Bebida> ListaDeBebidasEnCompra = new List<Bebida>();  //LISTA DE BEBIDAS QUE ESTABA COMPRANDO EL USUARIO, LA PASO PARA NO PERDER LO QUE ESTABA COMPRANDO

        HistorialCompraDal historialCompra = new HistorialCompraDal();

        public RegistroVentas(List<Bebida> ListaDeBebidasEnCompra)
        {
            InitializeComponent();

            this.ListaDeBebidasEnCompra = ListaDeBebidasEnCompra;

            listaCompras = historialCompra.TraerHistorial();

            foreach (var Compra in listaCompras)
            {
                LlenarDataGrid(Compra);
            }
        }

        public void LlenarDataGrid(Compra ItemCompraHistorial)
        {
            int n = historialCompraDGV.Rows.Add();
            historialCompraDGV.Rows[n].Cells[0].Value = ItemCompraHistorial.NombreCliente;
            historialCompraDGV.Rows[n].Cells[1].Value = ItemCompraHistorial.MontoPagar;
            historialCompraDGV.Rows[n].Cells[2].Value = ItemCompraHistorial.FormaPago;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 FormularioPrincipal = new Form1(ListaDeBebidasEnCompra);
            FormularioPrincipal.Show();
            this.Hide();
        }
    }
}
