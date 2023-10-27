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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.SlateBlue;
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.Font = new Font("Poppins", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(421, 764);
            btnConfirmar.Margin = new Padding(4, 5, 4, 5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(170, 80);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(450, 204);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(137, 34);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción*";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(474, 530);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(67, 34);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(425, 416);
            lblPrecioVenta.Margin = new Padding(4, 0, 4, 0);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(175, 34);
            lblPrecioVenta.TabIndex = 3;
            lblPrecioVenta.Text = "Precio de Venta*";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(474, 296);
            lblCosto.Margin = new Padding(4, 0, 4, 0);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(80, 34);
            lblCosto.TabIndex = 4;
            lblCosto.Text = "Costo*";
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Location = new Point(450, 635);
            lblIdUsuario.Margin = new Padding(4, 0, 4, 0);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(119, 34);
            lblIdUsuario.TabIndex = 5;
            lblIdUsuario.Text = "Id Usuario*";
            // 
            // numCosto
            // 
            numCosto.Location = new Point(379, 335);
            numCosto.Margin = new Padding(4, 5, 4, 5);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(286, 35);
            numCosto.TabIndex = 6;
            // 
            // numPrecioVenta
            // 
            numPrecioVenta.Location = new Point(379, 455);
            numPrecioVenta.Margin = new Padding(4, 5, 4, 5);
            numPrecioVenta.Name = "numPrecioVenta";
            numPrecioVenta.Size = new Size(286, 35);
            numPrecioVenta.TabIndex = 7;
            // 
            // numStock
            // 
            numStock.Location = new Point(376, 569);
            numStock.Margin = new Padding(4, 5, 4, 5);
            numStock.Name = "numStock";
            numStock.Size = new Size(286, 35);
            numStock.TabIndex = 8;
            // 
            // numIdUsuario
            // 
            numIdUsuario.Location = new Point(376, 674);
            numIdUsuario.Margin = new Padding(4, 5, 4, 5);
            numIdUsuario.Name = "numIdUsuario";
            numIdUsuario.Size = new Size(286, 35);
            numIdUsuario.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(376, 243);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(286, 35);
            txtDescripcion.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(379, 110);
            label1.Name = "label1";
            label1.Size = new Size(289, 53);
            label1.TabIndex = 11;
            label1.Text = "Crea un Producto";
            // 
            // frmCrearProducto
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1062, 1033);
            Controls.Add(label1);
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
            Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.SlateBlue;
            Margin = new Padding(4, 5, 4, 5);
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
        private Label label1;
    }
}