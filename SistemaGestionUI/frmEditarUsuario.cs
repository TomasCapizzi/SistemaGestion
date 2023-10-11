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
using SistemaGestionEntities;

namespace SistemaGestionUI
{
    public partial class frmEditarUsuario : Form
    {
        private Usuario usuario;
        public frmEditarUsuario(int IdUsuario)
        {
            InitializeComponent();
            this.usuario = new Usuario();

            var db = new SistemaGestionContext();

            // Query
            this.usuario = db.Usuarios.Where(x => x.Id.Equals(IdUsuario)).SingleOrDefault();
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtNombreUsuario.Text = usuario.NombreUsuario;
            txtContraseña.Text = usuario.Contraseña;
            txtMail.Text = usuario.Mail;
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.Mail = txtMail.Text;
            UsuarioBussines.ModificarUsuario(usuario);
            this.Close();
        }
    }
}
