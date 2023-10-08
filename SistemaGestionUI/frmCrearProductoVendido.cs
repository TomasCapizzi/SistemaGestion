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
    public partial class frmCrearProductoVendido : Form
    {
        public frmCrearProductoVendido()
        {
            InitializeComponent();
        }

        private void btnConfirmarProdVendido_Click(object sender, EventArgs e)
        {
            var productoVendido = new ProductoVendido
            {
                IdProducto = Convert.ToInt32(numIdProducto.Value),
                Stock = Convert.ToInt32(numStock.Value),
                IdVenta = Convert.ToInt32(numIdVenta.Value)
            };
            ProductoVendidoBussines.CrearProductoVendido(productoVendido);
            this.Close();
        }
    }
}
