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
            btnProductos = new Button();
            btnUsuarios = new Button();
            btnVentas = new Button();
            btnProductosVendidos = new Button();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(113, 104);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(133, 81);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Ver Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(530, 106);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(133, 81);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Ver Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(391, 106);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(133, 81);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ver Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductosVendidos
            // 
            btnProductosVendidos.Location = new Point(252, 106);
            btnProductosVendidos.Name = "btnProductosVendidos";
            btnProductosVendidos.Size = new Size(133, 81);
            btnProductosVendidos.TabIndex = 3;
            btnProductosVendidos.Text = "Ver Productos Vendidos";
            btnProductosVendidos.UseVisualStyleBackColor = true;
            btnProductosVendidos.Click += btnProductosVendidos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProductosVendidos);
            Controls.Add(btnVentas);
            Controls.Add(btnUsuarios);
            Controls.Add(btnProductos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductos;
        private Button btnUsuarios;
        private Button btnVentas;
        private Button btnProductosVendidos;
    }
}