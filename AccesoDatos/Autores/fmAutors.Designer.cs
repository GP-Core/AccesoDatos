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
            ((System.ComponentModel.ISupportInitialize)dgvAutors).BeginInit();
            SuspendLayout();
            // 
            // dgvAutors
            // 
            dgvAutors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutors.Location = new Point(0, 60);
            dgvAutors.Name = "dgvAutors";
            dgvAutors.ReadOnly = true;
            dgvAutors.RowHeadersWidth = 51;
            dgvAutors.Size = new Size(800, 390);
            dgvAutors.TabIndex = 0;
            dgvAutors.CellClick += dgvAutors_CellClick;
           
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(681, 12);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(94, 29);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "INSERTAR";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // frmAuthors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInsertar);
            Controls.Add(dgvAutors);
            Name = "frmAuthors";
            Text = "Authors";
            Activated += frmAuthors_Activated;
            Load += frmAuthors_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAutors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAutors;
        private Button btnInsertar;
    }
}