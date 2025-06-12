using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaGestorPedidos
{
    public class ListaPedidosAtendidos
    {
        private NodoLista cabeza;

        public void AgregarOrdenado(Pedido pedido)
        {
            NodoLista nuevo = new NodoLista(pedido);

            if (cabeza == null || pedido.Hora < cabeza.Pedido.Hora)
            {
                nuevo.Siguiente = cabeza;
                cabeza = nuevo;
            }
            else
            {
                NodoLista actual = cabeza;
                while (actual.Siguiente != null && actual.Siguiente.Pedido.Hora < pedido.Hora)
                {
                    actual = actual.Siguiente;
                }
                nuevo.Siguiente = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }

        public List<Pedido> ObtenerPedidos() 
        {
            List<Pedido> pedidos = new List<Pedido>();
            NodoLista actual = cabeza;
            while (actual != null)
            {
                pedidos.Add(actual.Pedido);
                actual = actual.Siguiente;
            }
            return pedidos;
        }

        public List<Pedido> BuscarPorNombre(string nombre)
        {
            List<Pedido> resultado = new List<Pedido>();
            foreach (Pedido p in ObtenerPedidos())
            {
                if (p.Cliente.ToLower().Contains(nombre.ToLower()))
                {
                    resultado.Add(p);
                }
            }
            return resultado;
        }


        public List<Pedido> FiltrarPorHorario(DateTime desde, DateTime hasta)
        {
            List<Pedido> resultado = new List<Pedido>();
            foreach (Pedido p in ObtenerPedidos())
            {
                if (p.Hora >= desde && p.Hora <= hasta)
                {
                    resultado.Add(p);
                }
            }
            return resultado;
        }


        public int Contar()
        {
            return ObtenerPedidos().Count;
        }

        public NodoLista Primero()
        {
            return cabeza;
        }
    }
}
