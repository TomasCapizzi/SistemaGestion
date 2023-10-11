namespace SistemaGestionUI
{
    partial class frmEditarProducto
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
            txtDescripcion = new TextBox();
            numIdUsuario = new NumericUpDown();
            numStock = new NumericUpDown();
            numPrecioVenta = new NumericUpDown();
            numCosto = new NumericUpDown();
            lblIdUsuario = new Label();
            lblCosto = new Label();
            lblPrecioVenta = new Label();
            lblStock = new Label();
            lblDescripcion = new Label();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(26, 49);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(152, 27);
            txtDescripcion.TabIndex = 32;
            // 
            // numIdUsuario
            // 
            numIdUsuario.Location = new Point(28, 339);
            numIdUsuario.Name = "numIdUsuario";
            numIdUsuario.Size = new Size(150, 27);
            numIdUsuario.TabIndex = 31;
            // 
            // numStock
            // 
            numStock.Location = new Point(28, 271);
            numStock.Name = "numStock";
            numStock.Size = new Size(150, 27);
            numStock.TabIndex = 30;
            // 
            // numPrecioVenta
            // 
            numPrecioVenta.Location = new Point(28, 186);
            numPrecioVenta.Name = "numPrecioVenta";
            numPrecioVenta.Size = new Size(150, 27);
            numPrecioVenta.TabIndex = 29;
            // 
            // numCosto
            // 
            numCosto.Location = new Point(28, 108);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(150, 27);
            numCosto.TabIndex = 28;
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Location = new Point(28, 316);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(76, 20);
            lblIdUsuario.TabIndex = 27;
            lblIdUsuario.Text = "Id Usuario";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(28, 85);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(47, 20);
            lblCosto.TabIndex = 26;
            lblCosto.Text = "Costo";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(28, 163);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(112, 20);
            lblPrecioVenta.TabIndex = 25;
            lblPrecioVenta.Text = "Precio de Venta";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(28, 248);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 24;
            lblStock.Text = "Stock";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(28, 21);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 23;
            lblDescripcion.Text = "Descripción";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(115, 403);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 39);
            btnConfirmar.TabIndex = 22;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // frmEditarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 481);
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
            Name = "frmEditarProducto";
            Text = "frmEditarProducto";
            Load += frmEditarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private NumericUpDown numIdUsuario;
        private NumericUpDown numStock;
        private NumericUpDown numPrecioVenta;
        private NumericUpDown numCosto;
        private Label lblIdUsuario;
        private Label lblCosto;
        private Label lblPrecioVenta;
        private Label lblStock;
        private Label lblDescripcion;
        private Button btnConfirmar;
    }
}