namespace SistemaGestionUI
{
    partial class frmProductos
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
            dgProductos = new DataGridView();
            btnEditar = new DataGridViewButtonColumn();
            btnEliminar = new DataGridViewButtonColumn();
            btnAgregar = new Button();
            label1 = new Label();
            txtBuscarProducto = new TextBox();
            btnBuscarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // dgProductos
            // 
            dgProductos.BackgroundColor = Color.SlateBlue;
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnEliminar });
            dgProductos.GridColor = Color.Linen;
            dgProductos.Location = new Point(420, 150);
            dgProductos.Margin = new Padding(4, 5, 4, 5);
            dgProductos.Name = "dgProductos";
            dgProductos.RowHeadersWidth = 51;
            dgProductos.RowTemplate.Height = 29;
            dgProductos.Size = new Size(1080, 500);
            dgProductos.TabIndex = 0;
            dgProductos.CellContentClick += dgProductos_CellContentClick;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.MinimumWidth = 6;
            btnEditar.Name = "btnEditar";
            btnEditar.Text = "Editar";
            btnEditar.Width = 125;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.MinimumWidth = 6;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.Width = 125;
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Location = new Point(1334, 35);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(166, 105);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(885, 58);
            label1.Name = "label1";
            label1.Size = new Size(180, 53);
            label1.TabIndex = 2;
            label1.Text = "Productos";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(420, 76);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(260, 35);
            txtBuscarProducto.TabIndex = 3;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(706, 65);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(94, 58);
            btnBuscarProducto.TabIndex = 4;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnBuscarProducto);
            Controls.Add(txtBuscarProducto);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(dgProductos);
            Cursor = Cursors.Hand;
            Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.SlateBlue;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmProductos";
            Text = "frmProductos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProductos;
        private Button btnAgregar;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnEliminar;
        private Label label1;
        private TextBox txtBuscarProducto;
        private Button btnBuscarProducto;
    }
}