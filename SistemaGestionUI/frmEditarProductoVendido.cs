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
    public partial class frmEditarProductoVendido : Form
    {
        private ProductoVendido productoVendido;
        private int idProdVendido;
        string path = @"https://localhost:7003/api/ProductosVendidos";
        public frmEditarProductoVendido(int IdProductoVendido)
        {
            InitializeComponent();
            idProdVendido = IdProductoVendido;
            /*
            this.productoVendido = new ProductoVendido();

            var db = new SistemaGestionContext();

            // Query
            this.productoVendido = db.ProductosVendidos.Where(x => x.Id.Equals(IdProductoVendido)).SingleOrDefault();
            numIdProducto.Value = productoVendido.IdProducto;
            numStock.Value = productoVendido.Stock;
            numIdVenta.Value = productoVendido.IdVenta;
            */
        }
        private async void CargarProductoVendido()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(path);
            List<ProductoVendido> listadoProdsVendidos = null;

            if (response.IsSuccessStatusCode)
            {
                listadoProdsVendidos = await response.Content.ReadFromJsonAsync<List<ProductoVendido>>();
                this.productoVendido = listadoProdsVendidos.Where(x => x.Id.Equals(idProdVendido)).SingleOrDefault();
                numIdProducto.Value = productoVendido.IdProducto;
                numStock.Value = productoVendido.Stock;
                numIdVenta.Value = productoVendido.IdVenta;
            }
        }

        private void frmEditarProductoVendido_Load(object sender, EventArgs e)
        {
            CargarProductoVendido();
        }

        private void btnConfirmarProdVendido_Click(object sender, EventArgs e)
        {
            productoVendido.IdProducto = Convert.ToInt32(numIdProducto.Value);
            productoVendido.Stock = Convert.ToInt32(numStock.Value);
            productoVendido.IdVenta = Convert.ToInt32(numIdVenta.Value);
            EditarProdVendido(this.productoVendido);
            //ProductoVendidoBussines.ModificarProductoVendido(productoVendido);
            this.Close();
        }

        private async Task<bool> EditarProdVendido(ProductoVendido productoVendido)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PutAsJsonAsync(path, productoVendido);
            response.EnsureSuccessStatusCode();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Producto Vendido Editado");
                this.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrrió un error al intentar editar el Producto Vendido");
                return false;
            }
        }
    }
}
