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
            ((System.ComponentModel.ISupportInitialize)dgVentas).BeginInit();
            SuspendLayout();
            // 
            // dgVentas
            // 
            dgVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVentas.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnEliminar });
            dgVentas.Location = new Point(12, 86);
            dgVentas.Name = "dgVentas";
            dgVentas.RowHeadersWidth = 51;
            dgVentas.RowTemplate.Height = 29;
            dgVentas.Size = new Size(970, 332);
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
            btnAgregarVenta.Location = new Point(12, 12);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(117, 53);
            btnAgregarVenta.TabIndex = 1;
            btnAgregarVenta.Text = "Agregar";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 450);
            Controls.Add(btnAgregarVenta);
            Controls.Add(dgVentas);
            Name = "frmVentas";
            Text = "frmVentas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgVentas;
        private Button btnAgregarVenta;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnEliminar;
    }
}