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
        private string nombreClienteModificar = null;

        public frmPrincipal()
        {
            InitializeComponent();
            dtpDesde.Enabled = false;
            dtpHasta.Enabled = false;
            btnFiltrar.Enabled = false;
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            Pedido nuevo = new Pedido()
            {
                Cliente = txtCliente.Text,
                Detalle = txtDetalle.Text,
                Hora = DateTime.Now
            };
            cola.Agregar(nuevo);
            MostrarCola();
            ActualizarContadores();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCliente.Text = "";
            txtDetalle.Text = "";

 
        }

        private void MostrarCola()
        {
            dgvCola.DataSource = null;
            dgvCola.DataSource = cola.ObtenerPedidos();

            if (dgvCola.Columns["Hora"] != null)
            {
                dgvCola.Columns["Hora"].DefaultCellStyle.Format = "HH:mm";
            }
        }


        private void MostrarAtendidos()
        {
            dgvAtendidos.DataSource = null;
            dgvAtendidos.DataSource = listaAtendidos.ObtenerPedidos();

            if (dgvAtendidos.Columns["Hora"] != null)
            {
                dgvAtendidos.Columns["Hora"].DefaultCellStyle.Format = "HH:mm";
            }
            ActualizarCantidadAtendidos();
        }

        private void ActualizarCantidadAtendidos()
        {
            lblCantidad.Text = $"Cantidad: {dgvAtendidos.Rows.Count}";
        }


        private void ActualizarContadores()
        {
            lblPendientes.Text = $"Pendientes: {cola.Contar()}";
            lblAtendidos.Text = $"Atendidos: {listaAtendidos.Contar()}";
        }

        private void btnProcesarSiguiente_Click(object sender, EventArgs e)
        {
            Pedido siguiente = cola.Quitar();
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text;
            dgvAtendidos.DataSource = listaAtendidos.BuscarPorNombre(nombre);
        }

        private void chkFiltrarHora_CheckedChanged(object sender, EventArgs e)
        {
            bool habilitar = chkFiltrarHora.Checked;

            dtpDesde.Enabled = habilitar;
            dtpHasta.Enabled = habilitar;
            btnFiltrar.Enabled = habilitar;

            if (!habilitar)
            {
                MostrarAtendidos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtCliente.Text.Trim();

            if (string.IsNullOrEmpty(nombreCliente))
            {
                MessageBox.Show("Por favor, ingrese el nombre del cliente a modificar.");
                return;
            }

            var pedido = cola.ObtenerPedidos()
                             .FirstOrDefault(p => p.Cliente.Equals(nombreCliente, StringComparison.OrdinalIgnoreCase));

            if (pedido != null)
            {
                txtDetalleNvo.Text = pedido.Detalle;
                nombreClienteModificar = pedido.Cliente; 
                MessageBox.Show("Pedido cargado para modificar. Ingrese el nuevo detalle y haga clic en Guardar.");
            }
            else
            {
                MessageBox.Show("Cliente no encontrado en la cola.");
            }
        }

        private void dgvAtendidos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var fila = dgvAtendidos.Rows[e.RowIndex];
                var pedido = (Pedido)fila.DataBoundItem;

                nombreClienteModificar = pedido.Cliente;
                txtDetalleNvo.Text = pedido.Detalle.ToString();

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevoDetalle = txtDetalleNvo.Text.Trim();

            if (string.IsNullOrEmpty(nombreClienteModificar) || string.IsNullOrEmpty(nuevoDetalle))
            {
                MessageBox.Show("Faltan datos. Seleccioná un pedido y escribí el nuevo detalle.");
                return;
            }

            NodoLista actual = listaAtendidos.Primero();

            while (actual != null)
            {
                if (actual.Pedido.Cliente.Equals(nombreClienteModificar, StringComparison.OrdinalIgnoreCase))
                {
                    actual.Pedido.Detalle = nuevoDetalle;
                    MessageBox.Show("Detalle modificado correctamente.");
                    MostrarAtendidos();
                    txtDetalleNvo.Text = "";
                    nombreClienteModificar = null;
                    return;
                }

                actual = actual.Siguiente;
            }

            MessageBox.Show("No se encontró el pedido.");
        }
    }
}
