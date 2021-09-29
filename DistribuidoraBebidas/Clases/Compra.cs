using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraBebidas.Clases
{
    public class Compra
    {
        public string NombreCliente { get; set; }

        public string FormaPago {get; set;}

        public float MontoPagar { get; set; }


        public Compra(string NombreCliente, float MontoPagar, string FormaPago)
        {
            this.NombreCliente = NombreCliente;
            this.FormaPago = FormaPago;
            this.MontoPagar = MontoPagar;
        }
    }
}
