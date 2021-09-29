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
using DistribuidoraBebidas.Formularios;

namespace DistribuidoraBebidas
{
    public partial class Form1 : Form
    {

        //faltantes, stock de bebidas

        public float suma = 0;

        BebidaDal bebidasBD = new BebidaDal();

        List<Bebida> TodasBebidasBD = new List<Bebida>();


        List<Bebida> BebidasAcomprar = new List<Bebida>();


        public Form1()
        {
            InitializeComponent();
            BebidasAcomprar.Clear();

            obtenerBebidas();

        }
        public Form1(List<Bebida> bebidas) // necesitamos que la lista se guarda por si queremos seguir agregando cosas
        {
            InitializeComponent();

            obtenerBebidas();
            RealizarSuma(bebidas);
        }


        //Podemos obtener la hora actual que esto nos ayudara para imprimirlo en el ticket
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Now;
            Hora.Text = date1.ToString();

            foreach (Bebida bebida in TodasBebidasBD)
            {
                if (bebida.Cantidad == 0)
                {
                    bebida.miBton.Enabled = false;
                    bebida.miBton.Text = "NO STOCK";
                    bebida.miBton.BackColor = Color.DarkGray;
                    bebida.miBton.ForeColor = Color.White;


                }
            }

            }


        //Obtenemos las bebidas desde base de datos
        public void obtenerBebidas()
        {
            bebidasBD.ObtenerBebidas(button25_Click, TodasBebidasBD); // relleno mi lista con las bebidas de base datos

            foreach (Bebida bebida in TodasBebidasBD)
            {
                if (bebida.Cantidad == 0)
                {
                    bebida.miBton.Enabled = false;
                    bebida.miBton.Text = "NO STOCK";
                    bebida.miBton.BackColor = Color.DarkGray;
                    bebida.miBton.ForeColor = Color.White;


                }

                PanelBebidas.Controls.Add(bebida.miBton);

            }

        }

        private void RealizarSuma(List<Bebida> bebidas)
        {
            BebidasAcomprar = bebidas;
            foreach (Bebida bebida in BebidasAcomprar)
            {
                suma = suma + bebida.Precio;
            }

            totalPagar.Text = suma.ToString();
        }


        //El super evento que compartiran todos los botones
        private void button25_Click(object sender, EventArgs e)
        {

            string BebidaSeleccionada = ((Button)sender).Text; // OBTENEMOS EL NOMBRE DEL OBJETO QUE REALIZO EL EVENTO

            foreach (Bebida bebida in TodasBebidasBD)
            {
                if (BebidaSeleccionada == bebida.Nombre.ToString()) // COMPARAMOS ESE NOMBRE CON LOS NOMBRES DE LAS BEBIDAS QUE TENEMOS
                                                                    // EN NUESTRA LISTA SI LO ENCUENTRA, OBTIENE SU VALOR Y LO SUMA
                {
                    if (bebida.Cantidad == 0)
                    {
                        bebida.miBton.Enabled = false;
                        bebida.miBton.Text = "NO STOCK";
                        bebida.miBton.BackColor = Color.DarkGray;
                        bebida.miBton.ForeColor = Color.White;
                    }
                    else
                    {
                        suma = suma + bebida.Precio; // hacemos la suma total 

                        bebidasBD.disminuirCantidadBebida(BebidaSeleccionada);

                        BebidasAcomprar.Add(bebida);   //Cuando lo encuentre que agregue al carrito la bebida

                        bebida.Cantidad--; // le restamos una cantidad

                    }
        
                }

            }
            totalPagar.Text = suma.ToString();

            /*string objeto = sender.ToString();
            foreach (Bebida bebida in TodasBebidasBD)
            {
               if(objeto.Contains(bebida.Nombre.ToString()) == true)
                {
                    suma = suma + bebida.Precio;
                }

            }*/

        }


        //Con eso agregaremos bebidas, por ahora al panel, pero despues directamente a la base de datos


        private void AgregarBebida_Click(object sender, EventArgs e)
        {
            AgregarBebida AgregarBebidaForm = new AgregarBebida(BebidasAcomprar, TodasBebidasBD);
            AgregarBebidaForm.Show();
            this.Hide();
           
        }



        private void clienteBtn_Click(object sender, EventArgs e)
        {
            Carrito CarritoForm = new Carrito(BebidasAcomprar); //le pasamos por parametro el carrito hasta el momento
            CarritoForm.Show();
            this.Hide();
        }

        private void RegistrosBtn_Click(object sender, EventArgs e)
        {
            RegistroVentas RegistroVentasFormulario = new RegistroVentas(BebidasAcomprar);
            RegistroVentasFormulario.Show();
            this.Hide();
            
        }
    }


}
