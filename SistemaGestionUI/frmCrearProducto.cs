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
    public partial class frmCrearProducto : Form
    {
        public frmCrearProducto()
        {
            InitializeComponent();
        }
        string path = @"https://localhost:7003/api/Productos";
        private void frmCrearProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var producto = new Producto
            {
                Descripcion = txtDescripcion.Text,
                Costo = numCosto.Value,
                PrecioVenta = numPrecioVenta.Value,
                Stock = numStock.Value,
                IdUsuario = Convert.ToInt32(numIdUsuario.Value)
            };

            if (txtDescripcion.Text != "" && numCosto.Value != 0 && numPrecioVenta.Value != 0 && numIdUsuario.Value != 0)
            {
                PostProducto(producto);
                //ProductoBussines.CrearProducto(producto);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debes completar los campos obligatorios");
            }
        }
        private async Task<bool> PostProducto(Producto producto)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.PostAsJsonAsync(path, producto);
            response.EnsureSuccessStatusCode();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Se creó el producto correctamente");
                this.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrió un error al crear el producto");
                return false;
            }

        }
    }
}
