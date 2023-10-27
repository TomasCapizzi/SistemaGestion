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
    public partial class frmProductosVendidos : Form
    {
        public frmProductosVendidos()
        {
            InitializeComponent();
        }

        private string path = @"https://localhost:7003/api/ProductosVendidos";
        private ProductoVendido productoVendido;

        private async Task getProdVendidos()
        {
            HttpClient client = new HttpClient();
            List<ProductoVendido> listadoProdVendidos = null;

            try
            {
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    listadoProdVendidos = await response.Content.ReadFromJsonAsync<List<ProductoVendido>>();
                    dgProductosVendidos.AutoGenerateColumns = true;
                    dgProductosVendidos.DataSource = listadoProdVendidos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error API");
            }
        }

        private void btnAgregarProductoVendido_Click(object sender, EventArgs e)
        {
            frmCrearProductoVendido productoVendido = new frmCrearProductoVendido();
            productoVendido.FormClosed += ProductoVendido_FormClosed;
            productoVendido.ShowDialog();
        }

        private void frmProductosVendidos_Load(object sender, EventArgs e)
        {
            getProdVendidos();
            //dgProductosVendidos.AutoGenerateColumns = true;
            //dgProductosVendidos.DataSource = ProductoVendidoBussines.ListaProductosVendidos();

        }

        private void ProductoVendido_FormClosed(object sender, FormClosedEventArgs e)
        {
            getProdVendidos();
            //dgProductosVendidos.AutoGenerateColumns = true;
            //dgProductosVendidos.DataSource = ProductoVendidoBussines.ListaProductosVendidos();
        }

        private void dgProductosVendidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
            if (this.dgProductosVendidos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int IdProductoVendido = (int)this.dgProductosVendidos.Rows[e.RowIndex].Cells["Id"].Value;

                frmEditarProductoVendido frmEditarProductoVendido = new frmEditarProductoVendido(IdProductoVendido);
                frmEditarProductoVendido.FormClosed += ProductoVendido_FormClosed;
                frmEditarProductoVendido.ShowDialog();
            }

            if (this.dgProductosVendidos.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int IdProductoVendido = (int)this.dgProductosVendidos.Rows[e.RowIndex].Cells["Id"].Value;
                DialogResult delete = MessageBox.Show("Desea Eliminar el producto vendido?", "Producto Vendido Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    HttpRequestMessage request = new HttpRequestMessage
                    {
                        Content = JsonContent.Create(IdProductoVendido),
                        Method = HttpMethod.Delete,
                        RequestUri = new Uri(path, UriKind.Absolute)
                    };
                    EliminarProdVendido(IdProductoVendido);
                    getProdVendidos();
                    /*
                    ProductoVendidoBussines.EliminarProductoVendido(IdProductoVendido);
                    dgProductosVendidos.AutoGenerateColumns = true;
                    dgProductosVendidos.DataSource = ProductoVendidoBussines.ListaProductosVendidos();*/
                }
            }
        }
        public async Task<bool> EliminarProdVendido(int IdProductoVendido)
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Content = JsonContent.Create(IdProductoVendido),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(path, UriKind.Absolute)
                };

                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Se elimino el producto vendido");
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrió un problema al intentar eliminar el producto vendido");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al intentar eliminar el producto vendido");
                return false;
            }
        }

        private void btnBuscarProductoVendido_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private async void Buscar()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(path);
            List<ProductoVendido>? listadoProductosVendidos = null;
            if (response.IsSuccessStatusCode)
            {
                listadoProductosVendidos = await response.Content.ReadFromJsonAsync<List<ProductoVendido>>();
                this.productoVendido = listadoProductosVendidos?.Where(x => x.IdProducto.Equals(numProductoVendido.Value)).SingleOrDefault();
                if (productoVendido != null)
                {
                    MessageBox.Show("Coincidencia");
                    numProductoVendido.Value = 0;
                    dgProductosVendidos.DataSource = null;
                    dgProductosVendidos.Refresh();
                    dgProductosVendidos.AutoGenerateColumns = true;
                    dgProductosVendidos.DataSource = productoVendido;
                }
                else
                {
                    MessageBox.Show("No encontramos lo que busca");
                    getProdVendidos();
                }
            }
        }
    }
}
