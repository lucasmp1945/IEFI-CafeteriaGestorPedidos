using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaGestorPedidos
{
    public class ColaPedidos
    {
        private NodoCola frente;
        private NodoCola fondo;

        public void Agregar(Pedido pedido)
        {
            NodoCola nuevo = new NodoCola(pedido);
            if (fondo == null)
            {
                frente = fondo = nuevo;
            }
            else
            {
                fondo.Siguiente = nuevo;
                fondo = nuevo;
            }
        }

        public Pedido Quitar()
        {
            if (frente == null) return null;

            Pedido pedido = frente.Pedido;
            frente = frente.Siguiente;
            if (frente == null) fondo = null;
            return pedido;
        }

        public List<Pedido> ObtenerPedidos() 
        {
            List<Pedido> pedidos = new List<Pedido>();
            NodoCola actual = frente;
            while (actual != null)
            {
                pedidos.Add(actual.Pedido);
                actual = actual.Siguiente;
            }
            return pedidos;
        }

        public int Contar()
        {
            return ObtenerPedidos().Count;
        }
    }
}
