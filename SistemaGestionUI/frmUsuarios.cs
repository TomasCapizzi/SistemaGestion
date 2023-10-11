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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            frmCrearUsuario usuario = new frmCrearUsuario();
            usuario.FormClosed += Usuario_FormClosed;
            usuario.ShowDialog();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dgUsuarios.AutoGenerateColumns = true;
            dgUsuarios.DataSource = UsuarioBussines.ListaUsuarios();
        }
        private void Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgUsuarios.AutoGenerateColumns = true;
            dgUsuarios.DataSource = UsuarioBussines.ListaUsuarios();
        }

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
            if (this.dgUsuarios.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int IdUsuario = (int)this.dgUsuarios.Rows[e.RowIndex].Cells["Id"].Value;

                frmEditarUsuario frmEditarUsuario = new frmEditarUsuario(IdUsuario);
                frmEditarUsuario.FormClosed += Usuario_FormClosed;
                frmEditarUsuario.ShowDialog();
            }

            if (this.dgUsuarios.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int IdUsuario = (int)this.dgUsuarios.Rows[e.RowIndex].Cells["Id"].Value;
                DialogResult delete = MessageBox.Show("Desea Eliminar el producto?", "Producto Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    UsuarioBussines.EliminarUsuario(IdUsuario);
                    dgUsuarios.AutoGenerateColumns = true;
                    dgUsuarios.DataSource = UsuarioBussines.ListaUsuarios();
                }
            }
        }
    }
}
