using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DistribuidoraBebidas.Clases;
using DistribuidoraBebidas.ClasesDal;

namespace DistribuidoraBebidas.Formularios
{
    public partial class Carrito : Form
    {
        public string ruta = "C:\\Users\\sanyalux\\Pictures\\caniche.jpg";

        BebidaDal bebidaBD = new BebidaDal();
        List<Bebida> BebidasEnCarrito = new List<Bebida>();
        
        int indice = 0;

        public Carrito()
        {
            InitializeComponent();
        }
        public Carrito(List<Bebida> BebidasAcomprar)
        {
            InitializeComponent();
            //Agregamos las bebidas al dataGridView

            BebidasEnCarrito = BebidasAcomprar;

            foreach (var Bebida in BebidasAcomprar)
            {
             //rellenamos el data grid view
             llenarDataGridView(Bebida);
     
            }

        }

        public void llenarDataGridView(Bebida bebidas)
        {
            //Adicionamos nuevo renglon

            //esto aumenta un renglon y devuelve su indice

            //Colocamos la informacion de la lista de bebidas
            int n = dgvCarritoCliente.Rows.Add();
            dgvCarritoCliente.Rows[n].Cells[0].Value = bebidas.Nombre;
            dgvCarritoCliente.Rows[n].Cells[1].Value = bebidas.Precio;
        }

        #region Imprimir Ticket

        private void imprimirBtn_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;

            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);

            int width = 200;
            int y = 20;

            e.Graphics.DrawString(Hora.Text.ToString(), font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Un ticket Feliz 2", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));

            Image imagen = Image.FromFile(ruta);
            e.Graphics.DrawImage(imagen, new Rectangle(0, y += 20, 50, 100));

        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime horario = DateTime.Now;
            Hora.Text = horario.ToString();
        }

        private void dgvCarritoCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;

            if (indice != -1)
            {
                dgvCarritoCliente.Rows[indice].Cells[0].Style.BackColor = Color.Red;
                dgvCarritoCliente.Rows[indice].Cells[1].Style.BackColor = Color.Red;
            }
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            if(indice != -1)
            {
                var SumarBebidaEliminada = BebidasEnCarrito[indice].Nombre; //Como se eliminó del carrito de comprar tenemos que sumar un +1 en el stock de nuevo
                bebidaBD.aumentarCantidadBebidad(SumarBebidaEliminada);
                
                dgvCarritoCliente.Rows.RemoveAt(indice); // borramos del data grid view
                
                BebidasEnCarrito.RemoveAt(indice); //Borramos la bebida que el cliente ya no quiere, de la lista donde guardamos las bebidas que quiere el cliente


                
            }
        }



        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 formularioPrincipal = new Form1(BebidasEnCarrito);
            formularioPrincipal.Show();
            this.Hide();

        }
    }
}
