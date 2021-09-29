using DistribuidoraBebidas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DistribuidoraBebidas.ClasesDal;
using DistribuidoraBebidas.Formularios;
using System.Drawing.Printing;

namespace DistribuidoraBebidas.Formularios
{
    public partial class CompletarPago : Form
    {
        List<Compra> ListaCompras = new List<Compra>();
        HistorialCompraDal HistorialCompra = new HistorialCompraDal();
        
        float suma = 0;
        
        public CompletarPago(List<Bebida> BebidasEnCarrito)
        {
            InitializeComponent();

            foreach (var Bebida in BebidasEnCarrito)
            {
                suma = suma + Bebida.Precio;
            }
            tbxMontoPagar.Text = suma.ToString();

        }

        private void CompletarPagoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Compra nuevaCompra = new Compra(txtNombreCliente.Text, suma, formaPagoCbx.Text);

                ListaCompras.Add(nuevaCompra);

                HistorialCompra.AgregarCompra(nuevaCompra);

                MessageBox.Show("Compra Cargada");


                imprimirDocument1 = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                
                imprimirDocument1.PrinterSettings = ps;

                imprimirDocument1.PrintPage += Imprimir;

          
            
                imprimirDocument1.Print();







                Form1 FormularioPrincipal = new Form1();
                FormularioPrincipal.Show();
                this.Hide();
            }
            catch (Exception)
            {

                MessageBox.Show("Ups! Algo Ocurrio");
            }
    
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            /*Creamos fuente*/
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            Font font2 = new Font("Arila", 17, FontStyle.Bold, GraphicsUnit.Point);

            int width = 200;
            int width2 = 400;
            int y = 20;

           


            e.Graphics.DrawString("NOMBRE: ", font2, Brushes.Black, new RectangleF(100,y+=20, width2, 30));
            e.Graphics.DrawString(txtNombreCliente.Text.ToString(), font, Brushes.Black, new RectangleF(100, y +=25, width, 20)); ;

            e.Graphics.DrawString("MONTO A PAGAR: ", font2, Brushes.Black, new RectangleF(100,y+=40, width2, 30));
            e.Graphics.DrawString(tbxMontoPagar.Text.ToString(), font, Brushes.Black, new RectangleF(100, y+=25,width+100,20));

            e.Graphics.DrawString("FORMA DE PAGO: ", font2, Brushes.Black, new RectangleF(100,y+=40, width2, 30));
            e.Graphics.DrawString(formaPagoCbx.Text.ToString(), font, Brushes.Black, new RectangleF(100, y +=25, width+100, 20));
            
        }
    }
}
