namespace SistemaGestionUI
{
    partial class frmEditarUsuario
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
            lblNombre = new Label();
            btnConfirmar = new Button();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombreUsuario = new TextBox();
            lblNombreUsuario = new Label();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            txtMail = new TextBox();
            lblMail = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(51, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 27);
            txtNombre.TabIndex = 43;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(53, 18);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 34;
            lblNombre.Text = "Nombre";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(140, 400);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 39);
            btnConfirmar.TabIndex = 33;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(51, 126);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(152, 27);
            txtApellido.TabIndex = 45;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(53, 98);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 44;
            lblApellido.Text = "Apellido";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(51, 196);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(152, 27);
            txtNombreUsuario.TabIndex = 47;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(53, 168);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(118, 20);
            lblNombreUsuario.TabIndex = 46;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(51, 266);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(152, 27);
            txtContraseña.TabIndex = 49;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(53, 238);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 48;
            lblContraseña.Text = "Contraseña";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(51, 347);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(152, 27);
            txtMail.TabIndex = 51;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(53, 319);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(38, 20);
            lblMail.TabIndex = 50;
            lblMail.Text = "Mail";
            // 
            // frmEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 450);
            Controls.Add(txtMail);
            Controls.Add(lblMail);
            Controls.Add(txtContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnConfirmar);
            Name = "frmEditarUsuario";
            Text = "frmEditarUsuario";
            Load += frmEditarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnConfirmar;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombreUsuario;
        private Label lblNombreUsuario;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private TextBox txtMail;
        private Label lblMail;
    }
}