using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryDelivida
{
    class Pedido
    {
        public Cliente cliente;
        public string fecha;
        public string producto;
        public int cantidad;
        public double precio;

        public double obtenerMontoTotal()
        {
            return Math.Round(cantidad * precio, 2);
        }
    }
}
