using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DistribuidoraBebidas.Clases;

namespace DistribuidoraBebidas.Clases
{
    public class CarritoCliente
    {
        public string nombre { get; set; }
        public int cantidadProductos { get; set; }

        public List<Bebida> BebidasEnCarrito = new List<Bebida>() ;
        public float presupuestoTotal { get; set;}

        public List<Bebida> LlenarListaBebidas(Bebida BebidaAgregada)
        {
            BebidasEnCarrito.Add(BebidaAgregada);
            return BebidasEnCarrito;
        }
    }
}
