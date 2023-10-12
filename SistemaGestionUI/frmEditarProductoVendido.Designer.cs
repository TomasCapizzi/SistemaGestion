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
            ((System.ComponentModel.ISupportInitialize)numIdVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdProducto).BeginInit();
            SuspendLayout();
            // 
            // btnConfirmarProdVendido
            // 
            btnConfirmarProdVendido.Location = new Point(63, 310);
            btnConfirmarProdVendido.Name = "btnConfirmarProdVendido";
            btnConfirmarProdVendido.Size = new Size(122, 59);
            btnConfirmarProdVendido.TabIndex = 25;
            btnConfirmarProdVendido.Text = "Confirmar";
            btnConfirmarProdVendido.UseVisualStyleBackColor = true;
            btnConfirmarProdVendido.Click += btnConfirmarProdVendido_Click;
            // 
            // numIdVenta
            // 
            numIdVenta.Location = new Point(63, 234);
            numIdVenta.Name = "numIdVenta";
            numIdVenta.Size = new Size(150, 27);
            numIdVenta.TabIndex = 24;
            // 
            // numStock
            // 
            numStock.Location = new Point(63, 157);
            numStock.Name = "numStock";
            numStock.Size = new Size(150, 27);
            numStock.TabIndex = 23;
            // 
            // numIdProducto
            // 
            numIdProducto.Location = new Point(63, 81);
            numIdProducto.Name = "numIdProducto";
            numIdProducto.Size = new Size(150, 27);
            numIdProducto.TabIndex = 22;
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Location = new Point(63, 211);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(63, 20);
            lblIdVenta.TabIndex = 21;
            lblIdVenta.Text = "Id Venta";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Location = new Point(63, 46);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(86, 20);
            lblIdProducto.TabIndex = 20;
            lblIdProducto.Text = "Id Producto";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(63, 134);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 19;
            lblStock.Text = "Stock";
            // 
            // frmEditarProductoVendido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 450);
            Controls.Add(btnConfirmarProdVendido);
            Controls.Add(numIdVenta);
            Controls.Add(numStock);
            Controls.Add(numIdProducto);
            Controls.Add(lblIdVenta);
            Controls.Add(lblIdProducto);
            Controls.Add(lblStock);
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
    }
}