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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos producto = new frmProductos();
            producto.FormClosed += Form1_FormClosed;
            producto.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosed(object? sender, FormClosedEventArgs e)
        {

        }

        private void btnProductosVendidos_Click(object sender, EventArgs e)
        {
            frmProductosVendidos productoVendido = new frmProductosVendidos();
            productoVendido.FormClosed += Form1_FormClosed;
            productoVendido.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas venta = new frmVentas();
            venta.FormClosed += Form1_FormClosed;
            venta.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios();
            usuario.FormClosed += Form1_FormClosed;
            usuario.ShowDialog();
        }
    }
}