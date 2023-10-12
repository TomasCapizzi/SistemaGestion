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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            frmCrearVenta venta = new frmCrearVenta();
            venta.FormClosed += Venta_FormClosed;
            venta.ShowDialog();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            dgVentas.AutoGenerateColumns = true;
            dgVentas.DataSource = VentaBussines.ListaVentas();
        }
        private void Venta_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgVentas.AutoGenerateColumns = true;
            dgVentas.DataSource = VentaBussines.ListaVentas();
        }

        private void dgVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
            if (this.dgVentas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int IdVenta = (int)this.dgVentas.Rows[e.RowIndex].Cells["Id"].Value;

                frmEditarVenta frmEditarVenta = new frmEditarVenta(IdVenta);
                frmEditarVenta.FormClosed += Venta_FormClosed;
                frmEditarVenta.ShowDialog();
            }

            if (this.dgVentas.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int IdVenta = (int)this.dgVentas.Rows[e.RowIndex].Cells["Id"].Value;
                DialogResult delete = MessageBox.Show("Desea Eliminar la venta?", "Venta Eliminada", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    VentaBussines.EliminarVenta(IdVenta);
                    dgVentas.AutoGenerateColumns = true;
                    dgVentas.DataSource = VentaBussines.ListaVentas();
                }
            }
        }
    }
}
