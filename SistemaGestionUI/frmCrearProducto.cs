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
    public partial class frmCrearProducto : Form
    {
        public frmCrearProducto()
        {
            InitializeComponent();
        }

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
            ProductoBussines.CrearProducto(producto);
            this.Close();
        }
    }
}
