using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionBussines;
using SistemaGestionEntities;

namespace SistemaGestionUI
{
    public partial class frmEditarProducto : Form
    {
        public frmEditarProducto()
        {
            InitializeComponent();
        }
        private Producto producto;

        public frmEditarProducto(int IdProducto)
        {
            InitializeComponent();

            this.producto = new Producto();

            var db = new SistemaGestionContext();

            // Query
            this.producto = db.Productos.Where(x => x.Id.Equals(IdProducto)).SingleOrDefault();
            txtDescripcion.Text = producto.Descripcion;
            numCosto.Value = producto.Costo;
            numPrecioVenta.Value = producto.PrecioVenta;
            numStock.Value = producto.Stock;
            numIdUsuario.Value = producto.IdUsuario;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            producto.Descripcion = txtDescripcion.Text;
            producto.Costo = numCosto.Value;
            producto.PrecioVenta = numPrecioVenta.Value;
            producto.Stock = numStock.Value;
            producto.IdUsuario = Convert.ToInt32(numIdUsuario.Value);
            ProductoBussines.ModificarProducto(producto);
            this.Close();
        }
    
        private void frmEditarProducto_Load(object sender, EventArgs e)
        {

        }
    
    }
}
