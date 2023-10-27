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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private string path = @"https://localhost:7003/api/Venta";
        private Venta venta;

        public async Task getVentas()
        {
            HttpClient client = new HttpClient();
            List<Venta> listadoVentas = null;

            try
            {
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    listadoVentas = await response.Content.ReadFromJsonAsync<List<Venta>>();
                    dgVentas.AutoGenerateColumns = true;
                    dgVentas.DataSource = listadoVentas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error API");
            }
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
            getVentas();

            //dgVentas.DataSource = VentaBussines.ListaVentas();
        }
        private void Venta_FormClosed(object sender, FormClosedEventArgs e)
        {
            getVentas();
            //dgVentas.AutoGenerateColumns = true;
            //dgVentas.DataSource = VentaBussines.ListaVentas();
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
                    EliminarVenta(IdVenta);
                    getVentas();
                    /*
                    VentaBussines.EliminarVenta(IdVenta);
                    dgVentas.AutoGenerateColumns = true;
                    dgVentas.DataSource = VentaBussines.ListaVentas();*/
                }
            }
        }

        private async Task<bool> EliminarVenta(int IdVenta)
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Content = JsonContent.Create(IdVenta),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(path, UriKind.Absolute)
                };

                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Se elemino la venta");
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrió un problema al intentar eliminar la venta");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al intentar eliminar la venta");
                return false;
            }
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private async void Buscar()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(path);
            List<Venta>? listadoVentas = null;
            if (response.IsSuccessStatusCode)
            {
                listadoVentas = await response.Content.ReadFromJsonAsync<List<Venta>>();
                this.venta = listadoVentas?.Where(x => x.IdUsuario.Equals(numVentas.Value)).SingleOrDefault();
                if (venta != null)
                {
                    MessageBox.Show("Coincidencia");
                    numVentas.Value = 0;
                    dgVentas.DataSource = null;
                    dgVentas.Refresh();
                    dgVentas.AutoGenerateColumns = true;
                    dgVentas.DataSource = venta;
                }
                else
                {
                    MessageBox.Show("No encontramos el producto que busca");
                    getVentas();
                }
            }
        }
    }
}
