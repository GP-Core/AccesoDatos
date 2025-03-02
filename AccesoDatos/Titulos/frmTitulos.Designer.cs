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
            btnInicio = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvTitulos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTitulos
            // 
            dgvTitulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTitulos.Location = new Point(3, 1);
            dgvTitulos.Name = "dgvTitulos";
            dgvTitulos.ReadOnly = true;
            dgvTitulos.RowHeadersWidth = 51;
            dgvTitulos.Size = new Size(800, 377);
            dgvTitulos.TabIndex = 0;
            dgvTitulos.CellClick += dgvTitulos_CellClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Location = new Point(3, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(794, 28);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnInicio
            // 
            btnInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.Location = new Point(3, 37);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(794, 29);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "REGRESAR AL INICIO";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnAgregar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnInicio, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 384);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 69);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // frmTitulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dgvTitulos);
            Name = "frmTitulos";
            Text = "TITULOS";
            Activated += frmTitulos_Activated;
            Load += frmTitulos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTitulos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTitulos;
        private Button btnAgregar;
        private Button btnInicio;
        private TableLayoutPanel tableLayoutPanel1;
    }
}