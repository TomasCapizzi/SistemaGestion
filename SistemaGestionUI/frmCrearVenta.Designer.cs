namespace SistemaGestionUI
{
    partial class frmCrearVenta
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
            numIdUsuario = new NumericUpDown();
            lblPrecioVenta = new Label();
            lblComentarios = new Label();
            btnConfirmarVenta = new Button();
            txtComentario = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).BeginInit();
            SuspendLayout();
            // 
            // numIdUsuario
            // 
            numIdUsuario.Location = new Point(359, 271);
            numIdUsuario.Margin = new Padding(4, 5, 4, 5);
            numIdUsuario.Name = "numIdUsuario";
            numIdUsuario.Size = new Size(276, 35);
            numIdUsuario.TabIndex = 13;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(442, 219);
            lblPrecioVenta.Margin = new Padding(4, 0, 4, 0);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(110, 34);
            lblPrecioVenta.TabIndex = 10;
            lblPrecioVenta.Text = "Id Usuario";
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.Location = new Point(428, 370);
            lblComentarios.Margin = new Padding(4, 0, 4, 0);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(140, 34);
            lblComentarios.TabIndex = 9;
            lblComentarios.Text = "Comentarios";
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.BackColor = Color.SlateBlue;
            btnConfirmarVenta.Cursor = Cursors.Hand;
            btnConfirmarVenta.Font = new Font("Poppins", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmarVenta.ForeColor = Color.White;
            btnConfirmarVenta.Location = new Point(407, 514);
            btnConfirmarVenta.Margin = new Padding(4, 5, 4, 5);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(170, 80);
            btnConfirmarVenta.TabIndex = 15;
            btnConfirmarVenta.Text = "Confirmar";
            btnConfirmarVenta.UseVisualStyleBackColor = false;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(359, 409);
            txtComentario.Margin = new Padding(4, 5, 4, 5);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(276, 35);
            txtComentario.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(377, 110);
            label1.Name = "label1";
            label1.Size = new Size(258, 53);
            label1.TabIndex = 17;
            label1.Text = "Crea una venta";
            // 
            // frmCrearVenta
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1062, 1033);
            Controls.Add(label1);
            Controls.Add(txtComentario);
            Controls.Add(btnConfirmarVenta);
            Controls.Add(numIdUsuario);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblComentarios);
            Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.SlateBlue;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmCrearVenta";
            Text = "frmCrearVenta";
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown numIdUsuario;
        private Label lblPrecioVenta;
        private Label lblComentarios;
        private Button btnConfirmarVenta;
        private TextBox txtComentario;
        private Label label1;
    }
}