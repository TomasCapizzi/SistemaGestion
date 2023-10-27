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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private string path = @"https://localhost:7003/api/Usuarios";
        private Usuario usuario;
        private async Task getUsuarios()
        {
            HttpClient client = new HttpClient();
            List<Usuario> listadoUsuarios = null;

            try
            {
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    listadoUsuarios = await response.Content.ReadFromJsonAsync<List<Usuario>>();
                    dgUsuarios.AutoGenerateColumns = true;
                    dgUsuarios.DataSource = listadoUsuarios;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error API");
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            frmCrearUsuario usuario = new frmCrearUsuario();
            usuario.FormClosed += Usuario_FormClosed;
            usuario.ShowDialog();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            getUsuarios();
            //dgUsuarios.AutoGenerateColumns = true;
            //dgUsuarios.DataSource = UsuarioBussines.ListaUsuarios();
        }
        private void Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            getUsuarios();
            //dgUsuarios.AutoGenerateColumns = true;
            //dgUsuarios.DataSource = UsuarioBussines.ListaUsuarios();
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
                DialogResult delete = MessageBox.Show("Desea Eliminar el usuario?", "Usuario Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    EliminarUsuario(IdUsuario);
                    getUsuarios();

                    /*
                    UsuarioBussines.EliminarUsuario(IdUsuario);
                    dgUsuarios.AutoGenerateColumns = true;
                    dgUsuarios.DataSource = UsuarioBussines.ListaUsuarios();*/
                }
            }
        }
        private async Task<bool> EliminarUsuario(int IdUsuario)
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Content = JsonContent.Create(IdUsuario),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(path, UriKind.Absolute)
                };

                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Se elemino el usuario");
                    this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrió un problema al intentar eliminar el usuario");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al intentar eliminar el usuario");
                return false;
            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private async void Buscar()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(path);
            List<Usuario>? listadoUsuarios = null;
            if (response.IsSuccessStatusCode)
            {
                listadoUsuarios = await response.Content.ReadFromJsonAsync<List<Usuario>>();
                this.usuario = listadoUsuarios?.Where(x => x.NombreUsuario.Equals(txtBuscarUsuario.Text)).SingleOrDefault();
                if (usuario != null)
                {
                    MessageBox.Show("Coincidencia: " + usuario.NombreUsuario);
                    txtBuscarUsuario.Text = "";
                    dgUsuarios.DataSource = null;
                    dgUsuarios.Refresh();
                    dgUsuarios.AutoGenerateColumns = true;
                    dgUsuarios.DataSource = usuario;
                }
                else
                {
                    MessageBox.Show("No encontramos el usuario que busca");
                    getUsuarios();
                }
            }
        }
    }
}
