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
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(357, 221);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(316, 35);
            txtNombre.TabIndex = 43;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(471, 176);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(92, 34);
            lblNombre.TabIndex = 34;
            lblNombre.Text = "Nombre";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.SlateBlue;
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.Font = new Font("Poppins", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(429, 805);
            btnConfirmar.Margin = new Padding(4, 5, 4, 5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(170, 80);
            btnConfirmar.TabIndex = 33;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(357, 345);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(316, 35);
            txtApellido.TabIndex = 45;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(471, 300);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(93, 34);
            lblApellido.TabIndex = 44;
            lblApellido.Text = "Apellido";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(357, 453);
            txtNombreUsuario.Margin = new Padding(4, 5, 4, 5);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(316, 35);
            txtNombreUsuario.TabIndex = 47;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(430, 404);
            lblNombreUsuario.Margin = new Padding(4, 0, 4, 0);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(169, 34);
            lblNombreUsuario.TabIndex = 46;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(357, 562);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(316, 35);
            txtContraseña.TabIndex = 49;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(445, 523);
            lblContraseña.Margin = new Padding(4, 0, 4, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(128, 34);
            lblContraseña.TabIndex = 48;
            lblContraseña.Text = "Contraseña";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(357, 687);
            txtMail.Margin = new Padding(4, 5, 4, 5);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(316, 35);
            txtMail.TabIndex = 51;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(485, 648);
            lblMail.Margin = new Padding(4, 0, 4, 0);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(54, 34);
            lblMail.TabIndex = 50;
            lblMail.Text = "Mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(419, 90);
            label1.Name = "label1";
            label1.Size = new Size(238, 53);
            label1.TabIndex = 52;
            label1.Text = "Editar Usuario";
            // 
            // frmEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1062, 1033);
            Controls.Add(label1);
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
            Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.SlateBlue;
            Margin = new Padding(4, 5, 4, 5);
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
        private Label label1;
    }
}