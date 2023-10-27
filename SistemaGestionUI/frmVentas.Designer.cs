namespace SistemaGestionUI
{
    partial class frmVentas
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
            dgVentas = new DataGridView();
            btnEditar = new DataGridViewButtonColumn();
            btnEliminar = new DataGridViewButtonColumn();
            btnAgregarVenta = new Button();
            lblVentas = new Label();
            btnBuscarVenta = new Button();
            numVentas = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVentas).BeginInit();
            SuspendLayout();
            // 
            // dgVentas
            // 
            dgVentas.BackgroundColor = Color.SlateBlue;
            dgVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVentas.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnEliminar });
            dgVentas.GridColor = Color.Linen;
            dgVentas.Location = new Point(420, 150);
            dgVentas.Margin = new Padding(4, 5, 4, 5);
            dgVentas.Name = "dgVentas";
            dgVentas.RowHeadersWidth = 51;
            dgVentas.RowTemplate.Height = 29;
            dgVentas.Size = new Size(1080, 500);
            dgVentas.TabIndex = 0;
            dgVentas.CellContentClick += dgVentas_CellContentClick;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.MinimumWidth = 6;
            btnEditar.Name = "btnEditar";
            btnEditar.Width = 125;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.MinimumWidth = 6;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Width = 125;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.Cursor = Cursors.Hand;
            btnAgregarVenta.ForeColor = Color.SlateBlue;
            btnAgregarVenta.Location = new Point(1339, 58);
            btnAgregarVenta.Margin = new Padding(4, 5, 4, 5);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(161, 82);
            btnAgregarVenta.TabIndex = 1;
            btnAgregarVenta.Text = "Agregar";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblVentas.ForeColor = Color.SlateBlue;
            lblVentas.Location = new Point(885, 70);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(132, 53);
            lblVentas.TabIndex = 2;
            lblVentas.Text = "Ventas";
            // 
            // btnBuscarVenta
            // 
            btnBuscarVenta.Location = new Point(601, 58);
            btnBuscarVenta.Name = "btnBuscarVenta";
            btnBuscarVenta.Size = new Size(94, 58);
            btnBuscarVenta.TabIndex = 6;
            btnBuscarVenta.Text = "Buscar";
            btnBuscarVenta.UseVisualStyleBackColor = true;
            btnBuscarVenta.Click += btnBuscarVenta_Click;
            // 
            // numVentas
            // 
            numVentas.Location = new Point(420, 70);
            numVentas.Name = "numVentas";
            numVentas.Size = new Size(150, 35);
            numVentas.TabIndex = 7;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1902, 1033);
            Controls.Add(numVentas);
            Controls.Add(btnBuscarVenta);
            Controls.Add(lblVentas);
            Controls.Add(btnAgregarVenta);
            Controls.Add(dgVentas);
            Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmVentas";
            Text = "frmVentas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgVentas;
        private Button btnAgregarVenta;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnEliminar;
        private Label lblVentas;
        private Button btnBuscarVenta;
        private NumericUpDown numVentas;
    }
}