namespace SistemaGestionUI
{
    partial class frmCrearUsuario
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
            txtNombre = new TextBox();
            lblMail = new Label();
            lbApellido = new Label();
            lblContraseña = new Label();
            lblNombre = new Label();
            btnConfirmar = new Button();
            txtApellido = new TextBox();
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            txtMail = new TextBox();
            lblNombreUsuario = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(57, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 27);
            txtNombre.TabIndex = 21;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(57, 293);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(38, 20);
            lblMail.TabIndex = 16;
            lblMail.Text = "Mail";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Location = new Point(59, 87);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(66, 20);
            lbApellido.TabIndex = 15;
            lbApellido.Text = "Apellido";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(57, 225);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 13;
            lblContraseña.Text = "Contraseña";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(59, 23);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(146, 405);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 39);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(57, 110);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(224, 27);
            txtApellido.TabIndex = 22;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(59, 181);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(222, 27);
            txtNombreUsuario.TabIndex = 23;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(57, 248);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(222, 27);
            txtContraseña.TabIndex = 24;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(59, 316);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(222, 27);
            txtMail.TabIndex = 25;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(59, 158);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(118, 20);
            lblNombreUsuario.TabIndex = 26;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // frmCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 468);
            Controls.Add(lblNombreUsuario);
            Controls.Add(txtMail);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblMail);
            Controls.Add(lbApellido);
            Controls.Add(lblContraseña);
            Controls.Add(lblNombre);
            Controls.Add(btnConfirmar);
            Name = "frmCrearUsuario";
            Text = "frmCrearUsuario";
            Load += frmCrearUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private NumericUpDown numStock;
        private NumericUpDown numPrecioVenta;
        private NumericUpDown numCosto;
        private Label lblMail;
        private Label lbApellido;
        private Label lblPrecioVenta;
        private Label lblContraseña;
        private Label lblNombre;
        private Button btnConfirmar;
        private TextBox txtApellido;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private TextBox txtMail;
        private Label lblNombreUsuario;
    }
}