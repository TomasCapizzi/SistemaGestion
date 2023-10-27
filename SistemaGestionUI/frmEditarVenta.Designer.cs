namespace SistemaGestionUI
{
    partial class frmEditarVenta
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
            txtComentario = new TextBox();
            btnConfirmarVenta = new Button();
            numIdUsuario = new NumericUpDown();
            lblPrecioVenta = new Label();
            lblComentarios = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).BeginInit();
            SuspendLayout();
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(352, 396);
            txtComentario.Margin = new Padding(4, 5, 4, 5);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(346, 35);
            txtComentario.TabIndex = 21;
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.BackColor = Color.SlateBlue;
            btnConfirmarVenta.Cursor = Cursors.Hand;
            btnConfirmarVenta.Font = new Font("Poppins", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmarVenta.ForeColor = Color.White;
            btnConfirmarVenta.Location = new Point(416, 536);
            btnConfirmarVenta.Margin = new Padding(4, 5, 4, 5);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(170, 80);
            btnConfirmarVenta.TabIndex = 20;
            btnConfirmarVenta.Text = "Confirmar";
            btnConfirmarVenta.UseVisualStyleBackColor = false;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            // 
            // numIdUsuario
            // 
            numIdUsuario.Location = new Point(352, 273);
            numIdUsuario.Margin = new Padding(4, 5, 4, 5);
            numIdUsuario.Name = "numIdUsuario";
            numIdUsuario.Size = new Size(346, 35);
            numIdUsuario.TabIndex = 19;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(454, 219);
            lblPrecioVenta.Margin = new Padding(4, 0, 4, 0);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(110, 34);
            lblPrecioVenta.TabIndex = 18;
            lblPrecioVenta.Text = "Id Usuario";
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.Location = new Point(436, 342);
            lblComentarios.Margin = new Padding(4, 0, 4, 0);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(140, 34);
            lblComentarios.TabIndex = 17;
            lblComentarios.Text = "Comentarios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(390, 98);
            label1.Name = "label1";
            label1.Size = new Size(243, 53);
            label1.TabIndex = 22;
            label1.Text = "Editar la venta";
            // 
            // frmEditarVenta
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
            Name = "frmEditarVenta";
            Text = "frmEditarVenta";
            Load += frmEditarVenta_Load;
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtComentario;
        private Button btnConfirmarVenta;
        private NumericUpDown numIdUsuario;
        private Label lblPrecioVenta;
        private Label lblComentarios;
        private Label label1;
    }
}