namespace SistemaGestionUI
{
    partial class frmCrearProductoVendido
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
            numIdVenta = new NumericUpDown();
            numStock = new NumericUpDown();
            numIdProducto = new NumericUpDown();
            lblIdVenta = new Label();
            lblIdProducto = new Label();
            lblStock = new Label();
            btnConfirmarProdVendido = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numIdVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdProducto).BeginInit();
            SuspendLayout();
            // 
            // numIdVenta
            // 
            numIdVenta.Location = new Point(387, 482);
            numIdVenta.Margin = new Padding(4, 5, 4, 5);
            numIdVenta.Name = "numIdVenta";
            numIdVenta.Size = new Size(262, 35);
            numIdVenta.TabIndex = 17;
            // 
            // numStock
            // 
            numStock.Location = new Point(387, 363);
            numStock.Margin = new Padding(4, 5, 4, 5);
            numStock.Name = "numStock";
            numStock.Size = new Size(262, 35);
            numStock.TabIndex = 16;
            // 
            // numIdProducto
            // 
            numIdProducto.Location = new Point(387, 245);
            numIdProducto.Margin = new Padding(4, 5, 4, 5);
            numIdProducto.Name = "numIdProducto";
            numIdProducto.Size = new Size(262, 35);
            numIdProducto.TabIndex = 14;
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Location = new Point(465, 443);
            lblIdVenta.Margin = new Padding(4, 0, 4, 0);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(95, 34);
            lblIdVenta.TabIndex = 13;
            lblIdVenta.Text = "Id Venta";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Location = new Point(442, 197);
            lblIdProducto.Margin = new Padding(4, 0, 4, 0);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(124, 34);
            lblIdProducto.TabIndex = 12;
            lblIdProducto.Text = "Id Producto";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(475, 324);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(67, 34);
            lblStock.TabIndex = 10;
            lblStock.Text = "Stock";
            // 
            // btnConfirmarProdVendido
            // 
            btnConfirmarProdVendido.BackColor = Color.SlateBlue;
            btnConfirmarProdVendido.Cursor = Cursors.Hand;
            btnConfirmarProdVendido.Font = new Font("Poppins", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmarProdVendido.ForeColor = Color.Linen;
            btnConfirmarProdVendido.Location = new Point(423, 592);
            btnConfirmarProdVendido.Margin = new Padding(4, 5, 4, 5);
            btnConfirmarProdVendido.Name = "btnConfirmarProdVendido";
            btnConfirmarProdVendido.Size = new Size(170, 80);
            btnConfirmarProdVendido.TabIndex = 18;
            btnConfirmarProdVendido.Text = "Confirmar";
            btnConfirmarProdVendido.UseVisualStyleBackColor = false;
            btnConfirmarProdVendido.Click += btnConfirmarProdVendido_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(323, 100);
            label1.Name = "label1";
            label1.Size = new Size(410, 53);
            label1.TabIndex = 19;
            label1.Text = "Crea el Producto Vendido";
            // 
            // frmCrearProductoVendido
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
            Name = "frmCrearProductoVendido";
            Text = "frmCrearProductoVendido";
            ((System.ComponentModel.ISupportInitialize)numIdVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numIdVenta;
        private NumericUpDown numStock;
        private NumericUpDown numIdProducto;
        private Label lblIdVenta;
        private Label lblIdProducto;
        private Label lblStock;
        private Button btnConfirmarProdVendido;
        private Label label1;
    }
}