using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = @"https://localhost:7003/api/Usuarios";
        private Usuario usuario = null;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosed(object? sender, FormClosedEventArgs e)
        {

        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            VerificarUsuario();
        }
        private async void VerificarUsuario()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(path);
            List<Usuario> listadoUsuarios = null;
            if (response.IsSuccessStatusCode)
            {
                listadoUsuarios = await response.Content.ReadFromJsonAsync<List<Usuario>>();
                this.usuario = listadoUsuarios.Where(x => x.NombreUsuario.Equals(txtMail.Text)).SingleOrDefault();
                if (usuario != null)
                {
                    MessageBox.Show("Sesión Iniciada");
                    txtMail.Text = "";
                    frmMenu menu = new frmMenu();
                    menu.FormClosed += Form1_FormClosed;
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario no existe, debes registrarte");
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmCrearUsuario usuario = new frmCrearUsuario();
            //usuario.FormClosed += Usuario_FormClosed;
            usuario.ShowDialog();
        }
    }
}