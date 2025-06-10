using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaGestorPedidos
{
    public class NodoLista
    {
        public Pedido Pedido { get; set; }
        public NodoLista Siguiente { get; set; }

        public NodoLista(Pedido pedido)
        {
            Pedido = pedido;
            Siguiente = null;
        }
    }
}
