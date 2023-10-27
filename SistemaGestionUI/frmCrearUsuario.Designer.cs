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
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(367, 231);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(307, 35);
            txtNombre.TabIndex = 21;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(476, 603);
            lblMail.Margin = new Padding(4, 0, 4, 0);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(63, 34);
            lblMail.TabIndex = 16;
            lblMail.Text = "Mail*";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Location = new Point(459, 283);
            lbApellido.Margin = new Padding(4, 0, 4, 0);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(102, 34);
            lbApellido.TabIndex = 15;
            lbApellido.Text = "Apellido*";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(447, 497);
            lblContraseña.Margin = new Padding(4, 0, 4, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(137, 34);
            lblContraseña.TabIndex = 13;
            lblContraseña.Text = "Contraseña*";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(459, 192);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(101, 34);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre*";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.SlateBlue;
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.Font = new Font("Poppins", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(422, 752);
            btnConfirmar.Margin = new Padding(4, 5, 4, 5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(170, 80);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(367, 322);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(307, 35);
            txtApellido.TabIndex = 22;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(370, 432);
            txtNombreUsuario.Margin = new Padding(4, 5, 4, 5);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(303, 35);
            txtNombreUsuario.TabIndex = 23;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(367, 536);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(303, 35);
            txtContraseña.TabIndex = 24;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(370, 642);
            txtMail.Margin = new Padding(4, 5, 4, 5);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(303, 35);
            txtMail.TabIndex = 25;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(422, 393);
            lblNombreUsuario.Margin = new Padding(4, 0, 4, 0);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(178, 34);
            lblNombreUsuario.TabIndex = 26;
            lblNombreUsuario.Text = "Nombre Usuario*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(385, 78);
            label1.Name = "label1";
            label1.Size = new Size(260, 53);
            label1.TabIndex = 27;
            label1.Text = "Crea tu Usuario";
            // 
            // frmCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1062, 1033);
            Controls.Add(label1);
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
            Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.SlateBlue;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmCrearUsuario";
            Text = "frmCrearUsuario";
            Load += frmCrearUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblMail;
        private Label lbApellido;
        private Label lblContraseña;
        private Label lblNombre;
        private Button btnConfirmar;
        private TextBox txtApellido;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private TextBox txtMail;
        private Label lblNombreUsuario;
        private Label label1;
    }
}