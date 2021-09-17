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
    public partial class AgregarBebida : Form
    {

        BebidaDal bebidaAgregar = new BebidaDal();
        public AgregarBebida()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // me da er
            try
            {
                bebidaAgregar.AgregarBebida(TbxNameBebida.Text, int.Parse(tbxCantidad.Text), int.Parse(tbxMililitros.Text), float.Parse(tbxPrecio.Text));
                MessageBox.Show("Bebida agregada con éxito");
            }
            catch (Exception)
            {

                MessageBox.Show("Ups, Algo sucedio");
            } 

              
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 agregarBebidaForm = new Form1();
            agregarBebidaForm.Show();
            this.Hide();
        }
    }
}
