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
    }
}
