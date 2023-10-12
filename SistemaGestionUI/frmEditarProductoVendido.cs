using SistemaGestionBussines;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class frmEditarProductoVendido : Form
    {
        private ProductoVendido productoVendido;
        public frmEditarProductoVendido(int IdProductoVendido)
        {
            InitializeComponent();
            this.productoVendido = new ProductoVendido();

            var db = new SistemaGestionContext();

            // Query
            this.productoVendido = db.ProductosVendidos.Where(x => x.Id.Equals(IdProductoVendido)).SingleOrDefault();
            numIdProducto.Value = productoVendido.IdProducto;
            numStock.Value = productoVendido.Stock;
            numIdVenta.Value = productoVendido.IdVenta;
        }

        private void frmEditarProductoVendido_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarProdVendido_Click(object sender, EventArgs e)
        {
            productoVendido.IdProducto = Convert.ToInt32(numIdProducto.Value);
            productoVendido.Stock = Convert.ToInt32(numStock.Value);
            productoVendido.IdVenta = Convert.ToInt32(numIdVenta.Value);
            ProductoVendidoBussines.ModificarProductoVendido(productoVendido);
            this.Close();
        }
    }
}
