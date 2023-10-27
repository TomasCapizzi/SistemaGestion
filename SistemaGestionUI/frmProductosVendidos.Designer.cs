namespace SistemaGestionUI
{
    partial class frmProductosVendidos
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
            btnAgregarProductoVendido = new Button();
            dgProductosVendidos = new DataGridView();
            btnEliminar = new DataGridViewButtonColumn();
            btnEditar = new DataGridViewButtonColumn();
            label1 = new Label();
            btnBuscarProductoVendido = new Button();
            numProductoVendido = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgProductosVendidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numProductoVendido).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarProductoVendido
            // 
            btnAgregarProductoVendido.AccessibleRole = AccessibleRole.Dial;
            btnAgregarProductoVendido.Location = new Point(1341, 40);
            btnAgregarProductoVendido.Margin = new Padding(4, 5, 4, 5);
            btnAgregarProductoVendido.Name = "btnAgregarProductoVendido";
            btnAgregarProductoVendido.Size = new Size(159, 100);
            btnAgregarProductoVendido.TabIndex = 0;
            btnAgregarProductoVendido.Text = "Agregar";
            btnAgregarProductoVendido.UseVisualStyleBackColor = true;
            btnAgregarProductoVendido.Click += btnAgregarProductoVendido_Click;
            // 
            // dgProductosVendidos
            // 
            dgProductosVendidos.BackgroundColor = Color.SlateBlue;
            dgProductosVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductosVendidos.Columns.AddRange(new DataGridViewColumn[] { btnEliminar, btnEditar });
            dgProductosVendidos.GridColor = Color.Linen;
            dgProductosVendidos.Location = new Point(420, 150);
            dgProductosVendidos.Margin = new Padding(4, 5, 4, 5);
            dgProductosVendidos.Name = "dgProductosVendidos";
            dgProductosVendidos.RowHeadersWidth = 51;
            dgProductosVendidos.RowTemplate.Height = 29;
            dgProductosVendidos.Size = new Size(1080, 500);
            dgProductosVendidos.TabIndex = 1;
            dgProductosVendidos.CellContentClick += dgProductosVendidos_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.MinimumWidth = 6;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.Width = 125;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.MinimumWidth = 6;
            btnEditar.Name = "btnEditar";
            btnEditar.Text = "Editar";
            btnEditar.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(786, 61);
            label1.Name = "label1";
            label1.Size = new Size(331, 53);
            label1.TabIndex = 2;
            label1.Text = "Productos Vendidos";
            // 
            // btnBuscarProductoVendido
            // 
            btnBuscarProductoVendido.Location = new Point(599, 61);
            btnBuscarProductoVendido.Name = "btnBuscarProductoVendido";
            btnBuscarProductoVendido.Size = new Size(94, 58);
            btnBuscarProductoVendido.TabIndex = 6;
            btnBuscarProductoVendido.Text = "Buscar";
            btnBuscarProductoVendido.UseVisualStyleBackColor = true;
            btnBuscarProductoVendido.Click += btnBuscarProductoVendido_Click;
            // 
            // numProductoVendido
            // 
            numProductoVendido.Location = new Point(420, 73);
            numProductoVendido.Name = "numProductoVendido";
            numProductoVendido.Size = new Size(150, 35);
            numProductoVendido.TabIndex = 7;
            // 
            // frmProductosVendidos
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1902, 1033);
            Controls.Add(numProductoVendido);
            Controls.Add(btnBuscarProductoVendido);
            Controls.Add(label1);
            Controls.Add(dgProductosVendidos);
            Controls.Add(btnAgregarProductoVendido);
            Cursor = Cursors.Hand;
            Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.SlateBlue;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmProductosVendidos";
            Text = "frmProductosVendidos";
            Load += frmProductosVendidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductosVendidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numProductoVendido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarProductoVendido;
        private DataGridView dgProductosVendidos;
        private DataGridViewButtonColumn btnEliminar;
        private DataGridViewButtonColumn btnEditar;
        private Label label1;
        private Button btnBuscarProductoVendido;
        private NumericUpDown numProductoVendido;
    }
}