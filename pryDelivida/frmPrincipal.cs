using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryDelivida
{
    public partial class frmPrincipal : Form
    {
       

        public frmPrincipal()
        {
            InitializeComponent();

            Tabla.setContenedor(Path.GetFullPath("Datos"));

            WindowState = FormWindowState.Maximized;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes c = new frmClientes();
            c.MdiParent = this;
            c.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos p = new frmPedidos();
            p.MdiParent = this;
            p.Show();
        }
    }
}
