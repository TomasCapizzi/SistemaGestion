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
    public partial class frmCrearProductoVendido : Form
    {
        public frmCrearProductoVendido()
        {
            InitializeComponent();
        }
        string path = @"https://localhost:7003/api/ProductosVendidos";

        private void btnConfirmarProdVendido_Click(object sender, EventArgs e)
        {
            var productoVendido = new ProductoVendido
            {
                IdProducto = Convert.ToInt32(numIdProducto.Value),
                Stock = Convert.ToInt32(numStock.Value),
                IdVenta = Convert.ToInt32(numIdVenta.Value)
            };
            PostProductoVendido(productoVendido);
            //ProductoVendidoBussines.CrearProductoVendido(productoVendido);
            this.Close();
        }

        private async Task<bool> PostProductoVendido(ProductoVendido productoVendido)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.PostAsJsonAsync(path, productoVendido);
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Se dio de alta correctamente");
                this.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrió un error al crear el Producto Vendido");
                return false;
            }
        }
    }
}
