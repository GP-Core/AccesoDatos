namespace AccesoDatos
{
    partial class frmTitulos
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
            dgvTitulos = new DataGridView();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTitulos).BeginInit();
            SuspendLayout();
            // 
            // dgvTitulos
            // 
            dgvTitulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTitulos.Location = new Point(0, 45);
            dgvTitulos.Name = "dgvTitulos";
            dgvTitulos.ReadOnly = true;
            dgvTitulos.RowHeadersWidth = 51;
            dgvTitulos.Size = new Size(800, 405);
            dgvTitulos.TabIndex = 0;
            dgvTitulos.CellClick += dgvTitulos_CellClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(647, 10);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // frmTitulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(dgvTitulos);
            Name = "frmTitulos";
            Text = "TITULOS";
            Activated += frmTitulos_Activated;
            Load += frmTitulos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTitulos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTitulos;
        private Button btnAgregar;
    }
}