using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaGestorPedidos
{
    public class Pedido
    {
        public string Cliente { get; set; }
        public string Detalle { get; set; }
        public DateTime Hora { get; set; }
    }
}
