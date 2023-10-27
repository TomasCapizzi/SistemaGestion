using SistemaGestionBussines;
using SistemaGestionEntities;
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

namespace SistemaGestionUI
{
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }
        string path = @"https://localhost:7003/api/Usuarios";

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                NombreUsuario = txtNombreUsuario.Text,
                Contraseña = txtContraseña.Text,
                Mail = txtMail.Text
            };
            if (txtNombre.Text != "" && txtApellido.Text  != "" && txtNombreUsuario.Text != "" && txtContraseña.Text != "" && txtMail.Text != "" )
            {
                PostUsuario(usuario);
                //UsuarioBussines.CrearUsuario(usuario);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debes completar los campos obligatorios");
            }

        }

        private async Task<bool> PostUsuario(Usuario usuario)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.PostAsJsonAsync(path, usuario);
            response.EnsureSuccessStatusCode();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Se dio de alta correctamente");
                this.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrió un error al crear Usuario");
                return false;
            }

        }
    }
}