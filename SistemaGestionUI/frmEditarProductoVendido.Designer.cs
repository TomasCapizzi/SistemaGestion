namespace SistemaGestionUI
{
    partial class frmEditarProductoVendido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConfirmarProdVendido = new Button();
            numIdVenta = new NumericUpDown();
            numStock = new NumericUpDown();
            numIdProducto = new NumericUpDown();
            lblIdVenta = new Label();
            lblIdProducto = new Label();
            lblStock = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numIdVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdProducto).BeginInit();
            SuspendLayout();
            // 
            // btnConfirmarProdVendido
            // 
            btnConfirmarProdVendido.BackColor = Color.SlateBlue;
            btnConfirmarProdVendido.Cursor = Cursors.Hand;
            btnConfirmarProdVendido.Font = new Font("Poppins", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmarProdVendido.ForeColor = Color.White;
            btnConfirmarProdVendido.Location = new Point(423, 605);
            btnConfirmarProdVendido.Margin = new Padding(4, 5, 4, 5);
            btnConfirmarProdVendido.Name = "btnConfirmarProdVendido";
            btnConfirmarProdVendido.Size = new Size(170, 80);
            btnConfirmarProdVendido.TabIndex = 25;
            btnConfirmarProdVendido.Text = "Confirmar";
            btnConfirmarProdVendido.UseVisualStyleBackColor = false;
            btnConfirmarProdVendido.Click += btnConfirmarProdVendido_Click;
            // 
            // numIdVenta
            // 
            numIdVenta.Location = new Point(373, 485);
            numIdVenta.Margin = new Padding(4, 5, 4, 5);
            numIdVenta.Name = "numIdVenta";
            numIdVenta.Size = new Size(296, 35);
            numIdVenta.TabIndex = 24;
            // 
            // numStock
            // 
            numStock.Location = new Point(373, 366);
            numStock.Margin = new Padding(4, 5, 4, 5);
            numStock.Name = "numStock";
            numStock.Size = new Size(296, 35);
            numStock.TabIndex = 23;
            // 
            // numIdProducto
            // 
            numIdProducto.Location = new Point(373, 248);
            numIdProducto.Margin = new Padding(4, 5, 4, 5);
            numIdProducto.Name = "numIdProducto";
            numIdProducto.Size = new Size(296, 35);
            numIdProducto.TabIndex = 22;
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Location = new Point(455, 446);
            lblIdVenta.Margin = new Padding(4, 0, 4, 0);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(95, 34);
            lblIdVenta.TabIndex = 21;
            lblIdVenta.Text = "Id Venta";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Location = new Point(448, 198);
            lblIdProducto.Margin = new Padding(4, 0, 4, 0);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(124, 34);
            lblIdProducto.TabIndex = 20;
            lblIdProducto.Text = "Id Producto";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(471, 327);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(67, 34);
            lblStock.TabIndex = 19;
            lblStock.Text = "Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(336, 96);
            label1.Name = "label1";
            label1.Size = new Size(393, 53);
            label1.TabIndex = 26;
            label1.Text = "Editar Producto Vendido";
            // 
            // frmEditarProductoVendido
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1062, 1033);
            Controls.Add(label1);
            Controls.Add(btnConfirmarProdVendido);
            Controls.Add(numIdVenta);
            Controls.Add(numStock);
            Controls.Add(numIdProducto);
            Controls.Add(lblIdVenta);
            Controls.Add(lblIdProducto);
            Controls.Add(lblStock);
            Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.SlateBlue;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmEditarProductoVendido";
            Text = "frmEditarProductoVendido";
            Load += frmEditarProductoVendido_Load;
            ((System.ComponentModel.ISupportInitialize)numIdVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmarProdVendido;
        private NumericUpDown numIdVenta;
        private NumericUpDown numStock;
        private NumericUpDown numIdProducto;
        private Label lblIdVenta;
        private Label lblIdProducto;
        private Label lblStock;
        private Label label1;
    }
}