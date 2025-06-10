using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaGestorPedidos
{
    public partial class frmPrincipal : Form
    {
        ColaPedidos cola = new ColaPedidos();
        ListaPedidosAtendidos listaAtendidos = new ListaPedidosAtendidos();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            Pedido nuevo = new Pedido()
            {
                Cliente = txtCliente.Text,
                Detalle = txtDetalle.Text,
                Hora = DateTime.Now
            };
            cola.Encolar(nuevo);
            MostrarCola();
            ActualizarContadores();
        }


        private void MostrarCola()
        {
            dgvCola.DataSource = null;
            dgvCola.DataSource = cola.ObtenerPedidos();
        }

        private void MostrarAtendidos()
        {
            dgvAtendidos.DataSource = null;
            dgvAtendidos.DataSource = listaAtendidos.ObtenerPedidos();
        }

        private void ActualizarContadores()
        {
            lblPendientes.Text = $"Pendientes: {cola.Contar()}";
            lblAtendidos.Text = $"Atendidos: {listaAtendidos.Contar()}";
        }

        private void btnProcesarSiguiente_Click(object sender, EventArgs e)
        {
            Pedido siguiente = cola.Desencolar();
            if (siguiente != null)
            {
                listaAtendidos.AgregarOrdenado(siguiente);
                MostrarCola();
                MostrarAtendidos();
                ActualizarContadores();
            }
        }

        private void btnExportarTxt_Click(object sender, EventArgs e)
        {
            var pedidos = listaAtendidos.FiltrarPorHorario(dtpDesde.Value, dtpHasta.Value);
            using (StreamWriter sw = new StreamWriter("reporte_pedidos.txt"))
            {
                sw.WriteLine("REPORTE DE PEDIDOS ATENDIDOS");
                sw.WriteLine($"Fecha de generación: {DateTime.Now:dd/MM/yyyy}");
                sw.WriteLine();
                sw.WriteLine("Hora   | Cliente                | Pedido");
                sw.WriteLine("----------------------------------------------------------------------");
                foreach (var p in pedidos)
                {
                    sw.WriteLine($"{p.Hora:HH:mm}  | {p.Cliente.PadRight(20)} | {p.Detalle}");
                }
            }
            MessageBox.Show("Archivo exportado correctamente.");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            dgvAtendidos.DataSource = listaAtendidos.FiltrarPorHorario(desde, hasta);
        }

        private void btnBuscarAtendidos_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text;
            dgvAtendidos.DataSource = listaAtendidos.BuscarPorNombre(nombre);
        }

    }
}
