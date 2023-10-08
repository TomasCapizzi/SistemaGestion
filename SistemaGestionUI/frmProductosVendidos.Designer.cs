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
            ((System.ComponentModel.ISupportInitialize)dgProductosVendidos).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarProductoVendido
            // 
            btnAgregarProductoVendido.Location = new Point(12, 23);
            btnAgregarProductoVendido.Name = "btnAgregarProductoVendido";
            btnAgregarProductoVendido.Size = new Size(116, 65);
            btnAgregarProductoVendido.TabIndex = 0;
            btnAgregarProductoVendido.Text = "Agregar";
            btnAgregarProductoVendido.UseVisualStyleBackColor = true;
            btnAgregarProductoVendido.Click += btnAgregarProductoVendido_Click;
            // 
            // dgProductosVendidos
            // 
            dgProductosVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductosVendidos.Location = new Point(12, 122);
            dgProductosVendidos.Name = "dgProductosVendidos";
            dgProductosVendidos.RowHeadersWidth = 51;
            dgProductosVendidos.RowTemplate.Height = 29;
            dgProductosVendidos.Size = new Size(760, 266);
            dgProductosVendidos.TabIndex = 1;
            // 
            // frmProductosVendidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgProductosVendidos);
            Controls.Add(btnAgregarProductoVendido);
            Name = "frmProductosVendidos";
            Text = "frmProductosVendidos";
            Load += frmProductosVendidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductosVendidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarProductoVendido;
        private DataGridView dgProductosVendidos;
    }
}