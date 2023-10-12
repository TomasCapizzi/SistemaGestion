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
    public partial class frmEditarVenta : Form
    {
        private Venta venta;
        public frmEditarVenta(int IdVenta)
        {
            InitializeComponent();

            this.venta = new Venta();

            var db = new SistemaGestionContext();

            // Query
            this.venta = db.Ventas.Where(x => x.Id.Equals(IdVenta)).SingleOrDefault();
            numIdUsuario.Value = venta.IdUsuario;
            txtComentario.Text = venta.Comentarios;
        }

        private void frmEditarVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            venta.IdUsuario = Convert.ToInt32(numIdUsuario.Value);
            venta.Comentarios = txtComentario.Text;
            VentaBussines.ModificarVenta(venta);
            this.Close();
        }
    }
}
