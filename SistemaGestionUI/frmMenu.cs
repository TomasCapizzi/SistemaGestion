using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
        private void frmMenu_FormClosed(object? sender, FormClosedEventArgs e)
        {

        }
        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            frmProductos producto = new frmProductos();
            producto.FormClosed += frmMenu_FormClosed;
            producto.ShowDialog();
        }

        private void btnProductosVendidos_Click_1(object sender, EventArgs e)
        {
            frmProductosVendidos productoVendido = new frmProductosVendidos();
            productoVendido.FormClosed += frmMenu_FormClosed;
            productoVendido.ShowDialog();
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            frmVentas venta = new frmVentas();
            venta.FormClosed += frmMenu_FormClosed;
            venta.ShowDialog();
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios();
            usuario.FormClosed += frmMenu_FormClosed;
            usuario.ShowDialog();
        }
    }
}
