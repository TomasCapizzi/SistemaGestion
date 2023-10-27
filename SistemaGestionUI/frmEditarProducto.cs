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
    public partial class frmEditarProducto : Form
    {
        private Producto producto;
        private int idProducto;
        string path = @"https://localhost:7003/api/Productos";

        public frmEditarProducto(int IdProducto)
        {
            InitializeComponent();
            idProducto = IdProducto;
            /*
            this.producto = new Producto();

            var db = new SistemaGestionContext();

            // Query
            this.producto = db.Productos.Where(x => x.Id.Equals(IdProducto)).SingleOrDefault();
            txtDescripcion.Text = producto.Descripcion;
            numCosto.Value = producto.Costo;
            numPrecioVenta.Value = producto.PrecioVenta;
            numStock.Value = producto.Stock;
            numIdUsuario.Value = producto.IdUsuario; */
        }

        private async void CargarProducto()
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(path);
            List<Producto> listadoProductos = null;

            if (response.IsSuccessStatusCode)
            {
                listadoProductos = await response.Content.ReadFromJsonAsync<List<Producto>>();
                this.producto = listadoProductos.Where(x => x.Id.Equals(idProducto)).SingleOrDefault();
                txtDescripcion.Text = producto.Descripcion;
                numCosto.Value = producto.Costo;
                numPrecioVenta.Value = producto.PrecioVenta;
                numStock.Value = producto.Stock;
                numIdUsuario.Value = producto.IdUsuario;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            producto.Descripcion = txtDescripcion.Text;
            producto.Costo = numCosto.Value;
            producto.PrecioVenta = numPrecioVenta.Value;
            producto.Stock = numStock.Value;
            producto.IdUsuario = Convert.ToInt32(numIdUsuario.Value);
            EditarProducto(this.producto);
            //ProductoBussines.ModificarProducto(producto);
            this.Close();
        }

        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
            CargarProducto();
        }

        private async Task<bool> EditarProducto(Producto producto)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PutAsJsonAsync(path, producto);
            response.EnsureSuccessStatusCode();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("producto Editado");
                this.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrrió un error al intentar editar el producto");
                return false;
            }
        }

    }
}
