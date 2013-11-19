using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDelivida
{
    public partial class frmPedidos : Form
    {
        TablaCliente datosCliente;
        TablaPedido datosPedidos;
        int idPedido;

        public frmPedidos()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            datosCliente = new TablaCliente();
            datosCliente.crearTabla();

            listarClientes();

            datosPedidos = new TablaPedido();
            datosPedidos.crearTabla();

            listarPedidos();
        }


        private void listarClientes()
        {
            lbxClientes.Items.Clear();
            cmbCliente.Items.Clear();
            Cliente c;

            for (int i = 0; i < datosCliente.getTotalFilas(); i++)
            {
                c = datosCliente.obtenerCliente(i);
                lbxClientes.Items.Add(c.nombre);
                cmbCliente.Items.Add(c.nombre);
            }

            lbxClientes.SelectedIndex = -1;
        }

        private void listarPedidos()
        {
            dgvLista.Rows.Clear();
            Pedido p;

            for (int i = 0; i < datosPedidos.getTotalFilas(); i++)
            {
                p = datosPedidos.obtenerPedido(i);
                dgvLista.Rows.Add(p.fecha, p.cliente.nombre, p.producto, p.cantidad, p.precio, p.obtenerMontoTotal());
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArrayList filtradas = datosPedidos.filtrarPedidos(cmbCampo.Text, txtValor.Text);

            dgvLista.Rows.Clear();
            Pedido p;

            for (int i = 0; i < filtradas.Count; i++)
            {
                p = (Pedido)filtradas[i];
                dgvLista.Rows.Add(p.fecha, p.cliente.nombre, p.producto, p.cantidad, p.precio, p.obtenerMontoTotal());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            listarPedidos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ArrayList fila = new ArrayList();

            fila.Add(cmbCliente.SelectedIndex);
            fila.Add(dtpFecha.Value.ToString("yyyy-MM-dd"));
            fila.Add(cmbProductos.Text);
            fila.Add(txtCantidad.Text);
            fila.Add(txtPrecio.Text);

            if (idPedido < datosPedidos.getTotalFilas())
            {
                datosPedidos.actualizarFila(idPedido, fila);
            }
            else
            {
                datosPedidos.agregarFila(fila);
            }

            listarClientes();

            cmbCliente.Text = "";
            cmbProductos.Text = "";
            txtCantidad.Clear();
            txtPrecio.Clear();

            dgvLista.Select();
        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {
            listarPedidos();

        }

        private void lbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList filtradas = datosPedidos.listarPedidosCliente(lbxClientes.SelectedIndex);

            dgvLista.Rows.Clear();
            Pedido p;

            for (int i = 0; i < filtradas.Count; i++)
            {
                p = (Pedido)filtradas[i];
                dgvLista.Rows.Add(p.fecha, p.cliente.nombre, p.producto, p.cantidad, p.precio, p.obtenerMontoTotal());
            }

            if (dgvLista.SelectedRows.Count > 0)
            {
                idPedido = dgvLista.SelectedRows[0].Index;

                mostrarDetallePedido();

                btnCancelar.Enabled = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
            }

        }

        private void mostrarDetallePedido()
        {
            Pedido p = datosPedidos.obtenerPedido(idPedido);

            cmbCliente.Text = p.cliente.nombre;
            dtpFecha.Value = Convert.ToDateTime(p.fecha);
            cmbProductos.Text = p.producto;
            txtCantidad.Text = p.cantidad.ToString(); ;
            txtPrecio.Text = p.precio.ToString();
        }

        private void dgvLista_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                idPedido = dgvLista.SelectedRows[0].Index;

                mostrarDetallePedido();

                btnCancelar.Enabled = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }
    }
}
