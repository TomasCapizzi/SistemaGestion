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
        private void Producto_FormClosed(object? sender, FormClosedEventArgs e)
        {
            dgProductos.AutoGenerateColumns = true;
            dgProductos.DataSource = ProductoBussines.ListaProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCrearProducto producto = new frmCrearProducto();
            producto.FormClosed += Producto_FormClosed;
            producto.ShowDialog();
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
            if (this.dgProductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int IdProducto = (int)this.dgProductos.Rows[e.RowIndex].Cells["Id"].Value;

                frmEditarProducto frmEditarProducto = new frmEditarProducto(IdProducto);
                frmEditarProducto.FormClosed += Producto_FormClosed;
                frmEditarProducto.ShowDialog();
            }

            if (this.dgProductos.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int IdProducto = (int)this.dgProductos.Rows[e.RowIndex].Cells["Id"].Value;
                DialogResult delete = MessageBox.Show("Desea Eliminar el producto?", "Producto Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    ProductoBussines.EliminarProducto(IdProducto);
                    dgProductos.AutoGenerateColumns = true;
                    dgProductos.DataSource = ProductoBussines.ListaProductos();
                }
            }
        }
    }
}
