using SistemaGestionBussines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class frmProductosVendidos : Form
    {
        public frmProductosVendidos()
        {
            InitializeComponent();
        }

        private void btnAgregarProductoVendido_Click(object sender, EventArgs e)
        {
            frmCrearProductoVendido productoVendido = new frmCrearProductoVendido();
            productoVendido.FormClosed += ProductoVendido_FormClosed;
            productoVendido.ShowDialog();
        }

        private void frmProductosVendidos_Load(object sender, EventArgs e)
        {
            dgProductosVendidos.AutoGenerateColumns = true;
            dgProductosVendidos.DataSource = ProductoVendidoBussines.ListaProductosVendidos();

        }

        private void ProductoVendido_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgProductosVendidos.AutoGenerateColumns = true;
            dgProductosVendidos.DataSource = ProductoVendidoBussines.ListaProductosVendidos();
        }
    }
}
