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
    public partial class frmEditarVenta : Form
    {
        private Venta venta;
        private int idVenta;
        string path = @"https://localhost:7003/api/Venta";
        public frmEditarVenta(int IdVenta)
        {
            InitializeComponent();
            idVenta = IdVenta;
            /*
            this.venta = new Venta();

            var db = new SistemaGestionContext();

            // Query
            this.venta = db.Ventas.Where(x => x.Id.Equals(IdVenta)).SingleOrDefault();
            numIdUsuario.Value = venta.IdUsuario;
            txtComentario.Text = venta.Comentarios; */
        }
        private async void CargarVenta()
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(path);
            List<Venta> listadoVentas = null;

            if (response.IsSuccessStatusCode)
            {
                listadoVentas = await response.Content.ReadFromJsonAsync<List<Venta>>();
                this.venta = listadoVentas.Where(x => x.Id.Equals(idVenta)).SingleOrDefault();
                numIdUsuario.Value = venta.IdUsuario;
                txtComentario.Text = venta.Comentarios;
            }
        }

        private void frmEditarVenta_Load(object sender, EventArgs e)
        {
            CargarVenta();
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            venta.IdUsuario = Convert.ToInt32(numIdUsuario.Value);
            venta.Comentarios = txtComentario.Text;
            EditarVenta(this.venta);
            //VentaBussines.ModificarVenta(venta);
            this.Close();
        }

        private async Task<bool> EditarVenta(Venta venta)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PutAsJsonAsync(path, venta);
            response.EnsureSuccessStatusCode();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Venta Editada");
                this.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrrió un error al intentar editar laa venta");
                return false;
            }
        }
    }
}
