using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace pryDelivida
{
    public partial class frmClientes : Form
    {

        TablaCliente datos;
        int idCliente;

        public frmClientes()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            datos = new TablaCliente();
            datos.crearTabla();

            listarClientes();
        }

        private void listarClientes()
        {
            dgvLista.Rows.Clear();
            Cliente c;

            for (int i = 0; i < datos.getTotalFilas(); i++)
            {
                c = datos.obtenerCliente(i);

                dgvLista.Rows.Add(c.nombre, c.dni, c.edad,c.estatura,c.peso, c.obtenerIMC());
            }
        }

        private void mostrarDetalleCliente()
        {
            Cliente c = datos.obtenerCliente(idCliente);

            txtNombre.Text = c.nombre;
            txtDNI.Text = c.dni;
            txtEdad.Text = c.edad.ToString();
            txtEstatura.Text = Convert.ToString(c.estatura * 100);
            txtPeso.Text = c.peso.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvLista.ClearSelection();
            txtNombre.Clear();
            txtDNI.Clear();
            txtEdad.Clear();
            txtEstatura.Clear();
            txtPeso.Clear();

            idCliente = datos.getTotalFilas();

            txtNombre.Focus();

            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ArrayList fila = new ArrayList();

            fila.Add(txtNombre.Text);
            fila.Add(txtDNI.Text);
            fila.Add(txtEdad.Text);
            fila.Add(txtEstatura.Text);
            fila.Add(txtPeso.Text);

            if (idCliente < datos.getTotalFilas())
            {
                datos.actualizarFila(idCliente, fila);
            }
            else
            {
                datos.agregarFila(fila);
            }

            listarClientes();

            txtNombre.Clear();
            txtDNI.Clear();
            txtEdad.Clear();
            txtEstatura.Clear();
            txtPeso.Clear();

            dgvLista.Select();

        }

        private void dgvLista_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                idCliente = dgvLista.SelectedRows[0].Index;

                mostrarDetalleCliente();

                btnCancelar.Enabled = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {
            listarClientes();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArrayList filtradas = datos.filtrarClientes(cmbCampo.Text, txtValor.Text);

            dgvLista.Rows.Clear();
            Cliente c;

            for (int i = 0; i < filtradas.Count; i++)
            {
                c = (Cliente)filtradas[i];

                dgvLista.Rows.Add(c.nombre, c.dni, c.edad, c.estatura, c.peso, c.obtenerIMC());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            listarClientes();
        }
    }
}
