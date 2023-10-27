namespace SistemaGestionUI
{
    partial class frmUsuarios
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
            dgUsuarios = new DataGridView();
            btnEditar = new DataGridViewButtonColumn();
            btnEliminar = new DataGridViewButtonColumn();
            btnAgregarUsuario = new Button();
            label1 = new Label();
            btnBuscarUsuario = new Button();
            txtBuscarUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgUsuarios
            // 
            dgUsuarios.BackgroundColor = Color.SlateBlue;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnEliminar });
            dgUsuarios.GridColor = Color.Linen;
            dgUsuarios.Location = new Point(420, 150);
            dgUsuarios.Margin = new Padding(4, 5, 4, 5);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.RowHeadersWidth = 51;
            dgUsuarios.RowTemplate.Height = 29;
            dgUsuarios.Size = new Size(1080, 500);
            dgUsuarios.TabIndex = 0;
            dgUsuarios.CellContentClick += dgUsuarios_CellContentClick;
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
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Cursor = Cursors.Hand;
            btnAgregarUsuario.Location = new Point(1345, 43);
            btnAgregarUsuario.Margin = new Padding(4, 5, 4, 5);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(155, 97);
            btnAgregarUsuario.TabIndex = 1;
            btnAgregarUsuario.Text = "Agregar";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(897, 62);
            label1.Name = "label1";
            label1.Size = new Size(159, 53);
            label1.TabIndex = 2;
            label1.Text = "Usuarios";
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.Location = new Point(705, 57);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(94, 58);
            btnBuscarUsuario.TabIndex = 6;
            btnBuscarUsuario.Text = "Buscar";
            btnBuscarUsuario.UseVisualStyleBackColor = true;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Location = new Point(419, 68);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(260, 35);
            txtBuscarUsuario.TabIndex = 5;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnBuscarUsuario);
            Controls.Add(txtBuscarUsuario);
            Controls.Add(label1);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(dgUsuarios);
            Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.SlateBlue;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgUsuarios;
        private Button btnAgregarUsuario;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnEliminar;
        private Label label1;
        private Button btnBuscarUsuario;
        private TextBox txtBuscarUsuario;
    }
}