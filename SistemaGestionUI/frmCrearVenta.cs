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
    public partial class frmCrearVenta : Form
    {
        public frmCrearVenta()
        {
            InitializeComponent();
        }
        string path = @"https://localhost:7003/api/Venta";

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            var venta = new Venta
            {
                IdUsuario = Convert.ToInt32(numIdUsuario.Value),
                Comentarios = txtComentario.Text
            };
            PostVenta(venta);
            //VentaBussines.CrearVenta(venta);
            this.Close();
        }
        private async Task<bool> PostVenta(Venta venta)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.PostAsJsonAsync(path, venta);
            response.EnsureSuccessStatusCode();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Se dio de alta correctamente");
                this.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrió un error al crear la Venta");
                return false;
            }

        }
    }
}
