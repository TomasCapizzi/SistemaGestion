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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        string path = @"https://localhost:7003/api/Productos";
        string pathProdVendido = @"https://localhost:7003/api/ProductosVendidos";
        private Producto? producto = null;
        private ProductoVendido? productoVendido = null;
        private async Task getProductos()
        {
            HttpClient client = new HttpClient();
            List<Producto> listadoProductos = null;
            try
            {
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    listadoProductos = await response.Content.ReadFromJsonAsync<List<Producto>>();
                    dgProductos.AutoGenerateColumns = true;
                    dgProductos.DataSource = listadoProductos;
                    dgProductos.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error API");
            }
        }
        private void frmProductos_Load(object sender, EventArgs e)
        {
            getProductos();
            //var productos = ProductoBussines.ListaProductos();
            /*
            dgProductos.AutoGenerateColumns = true;
            dgProductos.DataSource = ProductoBussines.ListaProductos();*/
        }
        private void Producto_FormClosed(object? sender, FormClosedEventArgs e)
        {
            getProductos();
            /*
            dgProductos.AutoGenerateColumns = true;
            dgProductos.DataSource = ProductoBussines.ListaProductos();*/
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCrearProducto producto = new frmCrearProducto();
            producto.FormClosed += Producto_FormClosed;
            producto.ShowDialog();
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
            if (this.dgProductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int IdProducto = (int)this.dgProductos.Rows[e.RowIndex].Cells["Id"].Value;

                frmEditarProducto frmEditarProducto = new frmEditarProducto(IdProducto);
                frmEditarProducto.FormClosed += Producto_FormClosed;
                frmEditarProducto.ShowDialog();
            }

            if (this.dgProductos.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int IdProducto = (int)this.dgProductos.Rows[e.RowIndex].Cells["Id"].Value;
                DialogResult delete = MessageBox.Show("Desea Eliminar el producto?", "Producto Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    EliminarProducto(IdProducto);
                    /*
                    bool chequear = Convert.ToBoolean(ChequearProductosVendidos(IdProducto));
                    if (!chequear)
                    {
                        EliminarProducto(IdProducto);
                    }
                    else
                    {
                        MessageBox.Show("Primero debes eliminar los productos vendidos de este producto");
                    }*/
                    getProductos();
                    /*
                    ProductoBussines.EliminarProducto(IdProducto);
                    dgProductos.AutoGenerateColumns = true;
                    dgProductos.DataSource = ProductoBussines.ListaProductos();*/
                }
            }
        }

        private async Task<bool> EliminarProducto(int IdProducto)
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Content = JsonContent.Create(IdProducto),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(path, UriKind.Absolute)
                };
                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    HttpRequestMessage requestProdVendido = new HttpRequestMessage
                    {
                        Content = JsonContent.Create(IdProducto),
                        Method = HttpMethod.Delete,
                        RequestUri = new Uri(pathProdVendido, UriKind.Absolute)
                    };
                    MessageBox.Show("Se elemino el producto y sus productos vendidos");
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrió un problema al intentar eliminar el producto");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al intentar eliminar el producto");
                return false;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private async void Buscar()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(path);
            List<Producto>? listadoProductos = null;
            if (response.IsSuccessStatusCode)
            {
                listadoProductos = await response.Content.ReadFromJsonAsync<List<Producto>>();
                this.producto = listadoProductos?.Where(x => x.Descripcion.Equals(txtBuscarProducto.Text)).SingleOrDefault();
                if (producto != null)
                {
                    MessageBox.Show("Coincidencia: " + producto.Descripcion);
                    txtBuscarProducto.Text = "";
                    dgProductos.DataSource = null;
                    dgProductos.Refresh();
                    dgProductos.AutoGenerateColumns = true;
                    dgProductos.DataSource = producto;
                }
                else
                {
                    MessageBox.Show("No encontramos el producto que busca");
                    getProductos();
                }
            }
        }
        private async Task<bool> ChequearProductosVendidos(int id)
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync(pathProdVendido);
                List<ProductoVendido>? listadoProductosVendidos = null;
                if (response.IsSuccessStatusCode)
                {
                    listadoProductosVendidos = await response.Content.ReadFromJsonAsync<List<ProductoVendido>>();
                    this.productoVendido = listadoProductosVendidos?.Where(x => x.IdProducto.Equals(id)).SingleOrDefault();
                    if (productoVendido != null)
                    {
                        return true;
                    }
                }
                return false;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
