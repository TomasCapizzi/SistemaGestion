namespace SistemaGestionUI
{
    partial class frmCrearProducto
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
            btnConfirmar = new Button();
            lblDescripcion = new Label();
            lblStock = new Label();
            lblPrecioVenta = new Label();
            lblCosto = new Label();
            lblIdUsuario = new Label();
            numCosto = new NumericUpDown();
            numPrecioVenta = new NumericUpDown();
            numStock = new NumericUpDown();
            numIdUsuario = new NumericUpDown();
            txtDescripcion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(150, 401);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 39);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(63, 19);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(63, 246);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(63, 161);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(112, 20);
            lblPrecioVenta.TabIndex = 3;
            lblPrecioVenta.Text = "Precio de Venta";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(63, 83);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(47, 20);
            lblCosto.TabIndex = 4;
            lblCosto.Text = "Costo";
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Location = new Point(63, 314);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(76, 20);
            lblIdUsuario.TabIndex = 5;
            lblIdUsuario.Text = "Id Usuario";
            // 
            // numCosto
            // 
            numCosto.Location = new Point(63, 106);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(150, 27);
            numCosto.TabIndex = 6;
            // 
            // numPrecioVenta
            // 
            numPrecioVenta.Location = new Point(63, 184);
            numPrecioVenta.Name = "numPrecioVenta";
            numPrecioVenta.Size = new Size(150, 27);
            numPrecioVenta.TabIndex = 7;
            // 
            // numStock
            // 
            numStock.Location = new Point(63, 269);
            numStock.Name = "numStock";
            numStock.Size = new Size(150, 27);
            numStock.TabIndex = 8;
            // 
            // numIdUsuario
            // 
            numIdUsuario.Location = new Point(63, 337);
            numIdUsuario.Name = "numIdUsuario";
            numIdUsuario.Size = new Size(150, 27);
            numIdUsuario.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(61, 47);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(152, 27);
            txtDescripcion.TabIndex = 10;
            // 
            // frmCrearProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 481);
            Controls.Add(txtDescripcion);
            Controls.Add(numIdUsuario);
            Controls.Add(numStock);
            Controls.Add(numPrecioVenta);
            Controls.Add(numCosto);
            Controls.Add(lblIdUsuario);
            Controls.Add(lblCosto);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblStock);
            Controls.Add(lblDescripcion);
            Controls.Add(btnConfirmar);
            Name = "frmCrearProducto";
            Text = "frmCrearProducto";
            Load += frmCrearProducto_Load;
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private Label lblDescripcion;
        private Label lblStock;
        private Label lblPrecioVenta;
        private Label lblCosto;
        private Label lblIdUsuario;
        private NumericUpDown numCosto;
        private NumericUpDown numPrecioVenta;
        private NumericUpDown numStock;
        private NumericUpDown numIdUsuario;
        private TextBox txtDescripcion;
    }
}