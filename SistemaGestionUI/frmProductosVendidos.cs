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

        private void dgProductosVendidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
            if (this.dgProductosVendidos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int IdProductoVendido = (int)this.dgProductosVendidos.Rows[e.RowIndex].Cells["Id"].Value;

                frmEditarProductoVendido frmEditarProductoVendido = new frmEditarProductoVendido(IdProductoVendido);
                frmEditarProductoVendido.FormClosed += ProductoVendido_FormClosed;
                frmEditarProductoVendido.ShowDialog();
            }

            if (this.dgProductosVendidos.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int IdProductoVendido = (int)this.dgProductosVendidos.Rows[e.RowIndex].Cells["Id"].Value;
                DialogResult delete = MessageBox.Show("Desea Eliminar el producto?", "Producto Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    ProductoVendidoBussines.EliminarProductoVendido(IdProductoVendido);
                    dgProductosVendidos.AutoGenerateColumns = true;
                    dgProductosVendidos.DataSource = ProductoVendidoBussines.ListaProductosVendidos();
                }
            }
        }
    }
}
