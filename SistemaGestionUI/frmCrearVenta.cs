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
    public partial class frmCrearVenta : Form
    {
        public frmCrearVenta()
        {
            InitializeComponent();
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            var venta = new Venta
            {
                IdUsuario = Convert.ToInt32(numIdUsuario.Value),
                Comentarios = txtComentario.Text
            };
            VentaBussines.CrearVenta(venta);
            this.Close();
        }
    }
}
