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

        List<Bebida> BebidasEnCarrito = new List<Bebida>();

        List<Bebida> TodasBebidasBD = new List<Bebida>();

        int indice = 0;



        public AgregarBebida(List<Bebida> BebidasDelUsuario, List<Bebida> bebidasBaseDatos)
        {
            InitializeComponent();
            BebidasEnCarrito = BebidasDelUsuario;
            TodasBebidasBD = bebidasBaseDatos;

            LlenarDataGridView(TodasBebidasBD);

        }

        public void LlenarDataGridView(List<Bebida> TodasBebidasBaseDatos)
        {
            foreach (var bebidas in TodasBebidasBaseDatos)
            {
            
            int n = AgregarStockDGV.Rows.Add();
            AgregarStockDGV.Rows[n].Cells[0].Value = bebidas.Nombre;
            AgregarStockDGV.Rows[n].Cells[1].Value = bebidas.Cantidad;
            }
        }
    


        private void button1_Click(object sender, EventArgs e)
        {
    
            try
            {
                bebidaAgregar.AgregarBebida(TbxNameBebida.Text, int.Parse(tbxCantidad.Text), int.Parse(tbxMililitros.Text), float.Parse(tbxPrecio.Text));
                MessageBox.Show("Bebida agregada con éxito");

                Form1 agregarBebidaForm = new Form1(BebidasEnCarrito);
                agregarBebidaForm.Show();
                this.Hide();
            }
            catch (Exception)
            {

                MessageBox.Show("Ups, Algo sucedio");
            } 

              
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 FormularioPrincipal = new Form1(BebidasEnCarrito);
            FormularioPrincipal.Show();
            this.Hide();
        }


        #region AgregarDisminuirStock
        private void AgregarStockDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            indice = e.RowIndex;
      
        }
        
        private void AgregarStockBebida_Click(object sender, EventArgs e)
        {
            if(indice != -1)
            {
                string nombreBebida = TodasBebidasBD[indice].Nombre;
                bebidaAgregar.aumentarCantidadBebidad(nombreBebida);

                AgregarStockDGV.Rows.Clear();
                LlenarDataGridView(TodasBebidasBD);
            }
        }

        private void RestarStockBebida_Click(object sender, EventArgs e)
        {
            if(indice != -1)
            {
                string nombreBebida = TodasBebidasBD[indice].Nombre;
                bebidaAgregar.disminuirCantidadBebida(nombreBebida);

                AgregarStockDGV.Rows.Clear();

                LlenarDataGridView(TodasBebidasBD);
            }
        }

        #endregion

    }
}
