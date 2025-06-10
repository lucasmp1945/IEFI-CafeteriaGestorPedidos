using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaGestorPedidos
{
    public class NodoCola
    {
        public Pedido Pedido { get; set; }
        public NodoCola Siguiente { get; set; }

        public NodoCola(Pedido pedido)
        {
            Pedido = pedido;
            Siguiente = null;
        }
    }
}
