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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(368, 237);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(281, 35);
            txtDescripcion.TabIndex = 32;
            // 
            // numIdUsuario
            // 
            numIdUsuario.Location = new Point(372, 687);
            numIdUsuario.Margin = new Padding(4, 5, 4, 5);
            numIdUsuario.Name = "numIdUsuario";
            numIdUsuario.Size = new Size(281, 35);
            numIdUsuario.TabIndex = 31;
            // 
            // numStock
            // 
            numStock.Location = new Point(372, 581);
            numStock.Margin = new Padding(4, 5, 4, 5);
            numStock.Name = "numStock";
            numStock.Size = new Size(281, 35);
            numStock.TabIndex = 30;
            // 
            // numPrecioVenta
            // 
            numPrecioVenta.Location = new Point(372, 450);
            numPrecioVenta.Margin = new Padding(4, 5, 4, 5);
            numPrecioVenta.Name = "numPrecioVenta";
            numPrecioVenta.Size = new Size(281, 35);
            numPrecioVenta.TabIndex = 29;
            // 
            // numCosto
            // 
            numCosto.Location = new Point(372, 328);
            numCosto.Margin = new Padding(4, 5, 4, 5);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(281, 35);
            numCosto.TabIndex = 28;
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Location = new Point(448, 648);
            lblIdUsuario.Margin = new Padding(4, 0, 4, 0);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(110, 34);
            lblIdUsuario.TabIndex = 27;
            lblIdUsuario.Text = "Id Usuario";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(467, 289);
            lblCosto.Margin = new Padding(4, 0, 4, 0);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(71, 34);
            lblCosto.TabIndex = 26;
            lblCosto.Text = "Costo";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(416, 411);
            lblPrecioVenta.Margin = new Padding(4, 0, 4, 0);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(166, 34);
            lblPrecioVenta.TabIndex = 25;
            lblPrecioVenta.Text = "Precio de Venta";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(471, 542);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(67, 34);
            lblStock.TabIndex = 24;
            lblStock.Text = "Stock";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(448, 198);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(128, 34);
            lblDescripcion.TabIndex = 23;
            lblDescripcion.Text = "Descripción";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.SlateBlue;
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.Font = new Font("Poppins", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(416, 783);
            btnConfirmar.Margin = new Padding(4, 5, 4, 5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(170, 80);
            btnConfirmar.TabIndex = 22;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(390, 103);
            label1.Name = "label1";
            label1.Size = new Size(259, 53);
            label1.TabIndex = 33;
            label1.Text = "Editar Producto";
            // 
            // frmEditarProducto
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
        private Label label1;
    }
}