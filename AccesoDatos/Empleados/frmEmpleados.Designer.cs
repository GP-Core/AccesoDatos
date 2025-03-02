namespace AccesoDatos
{
    partial class frmEmpleados
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
            dgvEmpleados = new DataGridView();
            btnInsertar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnInicio = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(-2, 1);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(800, 355);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.CellClick += dgvEmpleados_CellClick;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInsertar.Cursor = Cursors.Hand;
            btnInsertar.Location = new Point(3, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(798, 39);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "INSERTAR";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnInsertar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnInicio, 0, 1);
            tableLayoutPanel1.Location = new Point(-2, 359);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(804, 90);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnInicio
            // 
            btnInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.Location = new Point(3, 48);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(798, 39);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "REGRESAR AL INICIO";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dgvEmpleados);
            Name = "frmEmpleados";
            Text = "EMPLEADOS";
            Activated += frmEmpleados_Activated;
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Button btnInsertar;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnInicio;
    }
}