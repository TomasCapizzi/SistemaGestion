using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
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
        private int idUsuario;
        string path = @"https://localhost:7003/api/Usuarios";
        public frmEditarUsuario(int IdUsuario)
        {
            InitializeComponent();
            idUsuario = IdUsuario;
            /*
            this.usuario = new Usuario();

            var db = new SistemaGestionContext();

            // Query
            this.usuario = db.Usuarios.Where(x => x.Id.Equals(IdUsuario)).SingleOrDefault();
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtNombreUsuario.Text = usuario.NombreUsuario;
            txtContraseña.Text = usuario.Contraseña;
            txtMail.Text = usuario.Mail;*/
        }

        private async void CargarDatos()
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(path);
            List<Usuario> listadoUsuarios = null;

            if (response.IsSuccessStatusCode)
            {
                listadoUsuarios = await response.Content.ReadFromJsonAsync<List<Usuario>>();
                this.usuario = listadoUsuarios.Where(x => x.Id.Equals(idUsuario)).SingleOrDefault();
                txtNombre.Text = usuario.Nombre;
                txtApellido.Text = usuario.Apellido;
                txtNombreUsuario.Text = usuario.NombreUsuario;
                txtContraseña.Text = usuario.Contraseña;
                txtMail.Text = usuario.Mail;
            }
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.Mail = txtMail.Text;
            EditarUsuario(this.usuario);
            //UsuarioBussines.ModificarUsuario(usuario);
            this.Close();
        }

        private async Task<bool> EditarUsuario(Usuario usuario)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PutAsJsonAsync(path, usuario);
            response.EnsureSuccessStatusCode();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Usuario Editado");
                this.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrrió un error al intentar editar el Usuario");
                return false;
            }
        }
    }
}
