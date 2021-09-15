using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistribuidoraBebidas.Clases
{
    public class Bebida
    {
        public Button miBton = new Button();
       

        public int id { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
        public float Mililitros { get; set; }

        public Bebida (string Nombre, float Precio, int Cantidad, float Mililitro, EventHandler evento)
        {
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.Cantidad = Cantidad;
            this.Mililitros = Mililitro;

            miBton.Width = 105;
            miBton.Height = 95;
            miBton.Text = Nombre;
            miBton.Click += new EventHandler(evento);
            miBton.BackColor = Color.ForestGreen;
            miBton.ForeColor = Color.White;
            miBton.Font = new Font("Segoe", 12, FontStyle.Bold);
           

        }
        
     
    }
}
