using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionBussines;

namespace SistemaGestionUI
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            //var productos = ProductoBussines.ListaProductos();
            dgProductos.AutoGenerateColumns = true;
            dgProductos.DataSource = ProductoBussines.ListaProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCrearProducto producto = new frmCrearProducto();
            producto.FormClosed += Producto_FormClosed;
            producto.ShowDialog();
        }
        private void Producto_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgProductos.AutoGenerateColumns = true;
            dgProductos.DataSource = ProductoBussines.ListaProductos();
        }
    }
}
