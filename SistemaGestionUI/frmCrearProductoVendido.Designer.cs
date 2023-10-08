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
            ((System.ComponentModel.ISupportInitialize)numIdVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdProducto).BeginInit();
            SuspendLayout();
            // 
            // numIdVenta
            // 
            numIdVenta.Location = new Point(41, 270);
            numIdVenta.Name = "numIdVenta";
            numIdVenta.Size = new Size(150, 27);
            numIdVenta.TabIndex = 17;
            // 
            // numStock
            // 
            numStock.Location = new Point(41, 193);
            numStock.Name = "numStock";
            numStock.Size = new Size(150, 27);
            numStock.TabIndex = 16;
            // 
            // numIdProducto
            // 
            numIdProducto.Location = new Point(41, 117);
            numIdProducto.Name = "numIdProducto";
            numIdProducto.Size = new Size(150, 27);
            numIdProducto.TabIndex = 14;
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Location = new Point(41, 247);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(63, 20);
            lblIdVenta.TabIndex = 13;
            lblIdVenta.Text = "Id Venta";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Location = new Point(41, 82);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(86, 20);
            lblIdProducto.TabIndex = 12;
            lblIdProducto.Text = "Id Producto";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(41, 170);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 10;
            lblStock.Text = "Stock";
            // 
            // btnConfirmarProdVendido
            // 
            btnConfirmarProdVendido.Location = new Point(41, 346);
            btnConfirmarProdVendido.Name = "btnConfirmarProdVendido";
            btnConfirmarProdVendido.Size = new Size(122, 59);
            btnConfirmarProdVendido.TabIndex = 18;
            btnConfirmarProdVendido.Text = "Confirmar";
            btnConfirmarProdVendido.UseVisualStyleBackColor = true;
            btnConfirmarProdVendido.Click += btnConfirmarProdVendido_Click;
            // 
            // frmCrearProductoVendido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 450);
            Controls.Add(btnConfirmarProdVendido);
            Controls.Add(numIdVenta);
            Controls.Add(numStock);
            Controls.Add(numIdProducto);
            Controls.Add(lblIdVenta);
            Controls.Add(lblIdProducto);
            Controls.Add(lblStock);
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
    }
}