namespace AccesoDatos
{
    partial class frmAuthors
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
            dgvAutors = new DataGridView();
            btnInsertar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnInicio = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAutors).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAutors
            // 
            dgvAutors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutors.Dock = DockStyle.Fill;
            dgvAutors.Location = new Point(3, 3);
            dgvAutors.Name = "dgvAutors";
            dgvAutors.ReadOnly = true;
            dgvAutors.RowHeadersWidth = 51;
            dgvAutors.Size = new Size(783, 370);
            dgvAutors.TabIndex = 0;
            dgvAutors.CellClick += dgvAutors_CellClick;
            dgvAutors.MouseLeave += dgvAutors_MouseLeave;
            dgvAutors.MouseHover += dgvAutors_MouseHover;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInsertar.Location = new Point(3, 379);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(783, 28);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "INSERTAR";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            btnInsertar.MouseLeave += btnInsertar_MouseLeave;
            btnInsertar.MouseHover += btnInsertar_MouseHover;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvAutors, 0, 0);
            tableLayoutPanel1.Controls.Add(btnInsertar, 0, 1);
            tableLayoutPanel1.Controls.Add(btnInicio, 0, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.Size = new Size(789, 444);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnInicio
            // 
            btnInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInicio.Location = new Point(3, 413);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(783, 28);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "REGRESAR AL INICIO";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            btnInicio.MouseLeave += btnInicio_MouseLeave;
            btnInicio.MouseHover += btnInicio_MouseHover;
            // 
            // frmAuthors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "frmAuthors";
            Text = "Authors";
            Activated += frmAuthors_Activated;
            Load += frmAuthors_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAutors).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAutors;
        private Button btnInsertar;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button btnInicio;
    }
}