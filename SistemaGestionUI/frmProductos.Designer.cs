﻿namespace SistemaGestionUI
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
            btnAgregar = new Button();
            btnEditar = new DataGridViewButtonColumn();
            btnEliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // dgProductos
            // 
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnEliminar });
            dgProductos.Location = new Point(2, 115);
            dgProductos.Name = "dgProductos";
            dgProductos.RowHeadersWidth = 51;
            dgProductos.RowTemplate.Height = 29;
            dgProductos.Size = new Size(1311, 486);
            dgProductos.TabIndex = 0;
            dgProductos.CellContentClick += dgProductos_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 21);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 68);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
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
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 623);
            Controls.Add(btnAgregar);
            Controls.Add(dgProductos);
            Name = "frmProductos";
            Text = "frmProductos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgProductos;
        private Button btnAgregar;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnEliminar;
    }
}