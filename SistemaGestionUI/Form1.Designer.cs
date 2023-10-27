namespace SistemaGestionUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            label1 = new Label();
            btnIniciarSesion = new Button();
            btnRegistrar = new Button();
            label2 = new Label();
            lblcontraseña = new Label();
            lblMail = new Label();
            txtMail = new TextBox();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.SlateBlue;
            lblTitle.Location = new Point(705, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(317, 53);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Sistema de Gestión";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(696, 163);
            label1.Name = "label1";
            label1.Size = new Size(312, 42);
            label1.TabIndex = 5;
            label1.Text = "Inicia Sesión / Regístrate";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.SlateBlue;
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(679, 393);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(160, 70);
            btnIniciarSesion.TabIndex = 6;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkSlateBlue;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(842, 393);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(160, 70);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Regístrate";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 10;
            // 
            // lblcontraseña
            // 
            lblcontraseña.AutoSize = true;
            lblcontraseña.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblcontraseña.ForeColor = Color.DarkSlateBlue;
            lblcontraseña.Location = new Point(571, 316);
            lblcontraseña.Name = "lblcontraseña";
            lblcontraseña.Size = new Size(128, 34);
            lblcontraseña.TabIndex = 9;
            lblcontraseña.Text = "Contraseña";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail.ForeColor = Color.DarkSlateBlue;
            lblMail.Location = new Point(575, 233);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(87, 34);
            lblMail.TabIndex = 11;
            lblMail.Text = "Usuario";
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(673, 232);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(394, 37);
            txtMail.TabIndex = 12;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(705, 317);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(362, 37);
            txtPass.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtPass);
            Controls.Add(txtMail);
            Controls.Add(lblMail);
            Controls.Add(lblcontraseña);
            Controls.Add(label2);
            Controls.Add(btnRegistrar);
            Controls.Add(btnIniciarSesion);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Sistema de Gestión";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Label label1;
        private Button btnIniciarSesion;
        private Button btnRegistrar;
        private Label label2;
        private Label lblcontraseña;
        private Label lblMail;
        private TextBox txtMail;
        private TextBox txtPass;
    }
}