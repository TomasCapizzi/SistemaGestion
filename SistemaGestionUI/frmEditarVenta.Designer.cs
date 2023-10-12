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
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).BeginInit();
            SuspendLayout();
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(52, 195);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(253, 27);
            txtComentario.TabIndex = 21;
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.Location = new Point(52, 276);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(124, 57);
            btnConfirmarVenta.TabIndex = 20;
            btnConfirmarVenta.Text = "Confirmar";
            btnConfirmarVenta.UseVisualStyleBackColor = true;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            // 
            // numIdUsuario
            // 
            numIdUsuario.Location = new Point(52, 110);
            numIdUsuario.Name = "numIdUsuario";
            numIdUsuario.Size = new Size(150, 27);
            numIdUsuario.TabIndex = 19;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(52, 87);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(76, 20);
            lblPrecioVenta.TabIndex = 18;
            lblPrecioVenta.Text = "Id Usuario";
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.Location = new Point(52, 172);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(93, 20);
            lblComentarios.TabIndex = 17;
            lblComentarios.Text = "Comentarios";
            // 
            // frmEditarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 450);
            Controls.Add(txtComentario);
            Controls.Add(btnConfirmarVenta);
            Controls.Add(numIdUsuario);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblComentarios);
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
    }
}