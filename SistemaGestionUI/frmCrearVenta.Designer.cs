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
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).BeginInit();
            SuspendLayout();
            // 
            // numIdUsuario
            // 
            numIdUsuario.Location = new Point(34, 150);
            numIdUsuario.Name = "numIdUsuario";
            numIdUsuario.Size = new Size(150, 27);
            numIdUsuario.TabIndex = 13;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(34, 127);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(76, 20);
            lblPrecioVenta.TabIndex = 10;
            lblPrecioVenta.Text = "Id Usuario";
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.Location = new Point(34, 212);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(93, 20);
            lblComentarios.TabIndex = 9;
            lblComentarios.Text = "Comentarios";
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.Location = new Point(34, 316);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(124, 57);
            btnConfirmarVenta.TabIndex = 15;
            btnConfirmarVenta.Text = "Confirmar";
            btnConfirmarVenta.UseVisualStyleBackColor = true;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(34, 235);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(253, 27);
            txtComentario.TabIndex = 16;
            // 
            // frmCrearVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 450);
            Controls.Add(txtComentario);
            Controls.Add(btnConfirmarVenta);
            Controls.Add(numIdUsuario);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblComentarios);
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
    }
}