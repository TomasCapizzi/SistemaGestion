namespace SistemaGestionUI
{
    partial class frmMenu
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
            btnProductosVendidos = new Button();
            btnVentas = new Button();
            btnUsuarios = new Button();
            btnProductos = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnProductosVendidos
            // 
            btnProductosVendidos.BackColor = Color.SlateBlue;
            btnProductosVendidos.Cursor = Cursors.Hand;
            btnProductosVendidos.Font = new Font("Poppins", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductosVendidos.ForeColor = Color.White;
            btnProductosVendidos.Location = new Point(502, 257);
            btnProductosVendidos.Name = "btnProductosVendidos";
            btnProductosVendidos.Size = new Size(578, 80);
            btnProductosVendidos.TabIndex = 7;
            btnProductosVendidos.Text = "Ver Productos Vendidos";
            btnProductosVendidos.UseVisualStyleBackColor = false;
            btnProductosVendidos.Click += btnProductosVendidos_Click_1;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.SlateBlue;
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.Font = new Font("Poppins", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(502, 354);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(578, 80);
            btnVentas.TabIndex = 6;
            btnVentas.Text = "Ver Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click_1;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.SlateBlue;
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.Font = new Font("Poppins", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(502, 464);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(578, 80);
            btnUsuarios.TabIndex = 5;
            btnUsuarios.Text = "Ver Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click_1;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.SlateBlue;
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.Font = new Font("Poppins", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(502, 156);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(578, 80);
            btnProductos.TabIndex = 4;
            btnProductos.Text = "Ver Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.SlateBlue;
            lblTitle.Location = new Point(655, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(317, 53);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Sistema de Gestión";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1902, 1033);
            Controls.Add(lblTitle);
            Controls.Add(btnProductosVendidos);
            Controls.Add(btnVentas);
            Controls.Add(btnUsuarios);
            Controls.Add(btnProductos);
            Name = "frmMenu";
            Text = "Menu";
            Load += frmMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProductosVendidos;
        private Button btnVentas;
        private Button btnUsuarios;
        private Button btnProductos;
        private Label lblTitle;
    }
}