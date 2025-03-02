namespace AccesoDatos
{
    partial class frmInsertarEmp
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
            dtpHireDate = new DateTimePicker();
            btnAgregar = new Button();
            btnCancelar = new Button();
            label8 = new Label();
            txtPubId = new TextBox();
            label7 = new Label();
            txtJlevel = new TextBox();
            label6 = new Label();
            txtJId = new TextBox();
            label5 = new Label();
            txtMinit = new TextBox();
            label4 = new Label();
            txtLName = new TextBox();
            label3 = new Label();
            txtFName = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(483, 271);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(281, 27);
            dtpHireDate.TabIndex = 38;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(200, 391);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 29);
            btnAgregar.TabIndex = 37;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(458, 391);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 29);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "CERRAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(483, 239);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 34;
            label8.Text = "Hire Date";
            // 
            // txtPubId
            // 
            txtPubId.Location = new Point(345, 262);
            txtPubId.Name = "txtPubId";
            txtPubId.Size = new Size(104, 27);
            txtPubId.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(345, 239);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 32;
            label7.Text = "Pub ID";
            // 
            // txtJlevel
            // 
            txtJlevel.Location = new Point(188, 262);
            txtJlevel.Name = "txtJlevel";
            txtJlevel.Size = new Size(104, 27);
            txtJlevel.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(188, 239);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 30;
            label6.Text = "Job Level";
            // 
            // txtJId
            // 
            txtJId.Location = new Point(36, 262);
            txtJId.Name = "txtJId";
            txtJId.Size = new Size(104, 27);
            txtJId.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 239);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 28;
            label5.Text = "Job ID";
            // 
            // txtMinit
            // 
            txtMinit.Location = new Point(335, 160);
            txtMinit.Name = "txtMinit";
            txtMinit.Size = new Size(100, 27);
            txtMinit.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 123);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 26;
            label4.Text = "Minit";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(502, 160);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(245, 27);
            txtLName.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(502, 123);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 24;
            label3.Text = "Last Name";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(36, 160);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(245, 27);
            txtFName.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 123);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 22;
            label2.Text = "Frist Name";
            // 
            // txtID
            // 
            txtID.Location = new Point(36, 68);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 31);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 20;
            label1.Text = "ID";
            // 
            // frmInsertarEmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpHireDate);
            Controls.Add(btnAgregar);
            Controls.Add(btnCancelar);
            Controls.Add(label8);
            Controls.Add(txtPubId);
            Controls.Add(label7);
            Controls.Add(txtJlevel);
            Controls.Add(label6);
            Controls.Add(txtJId);
            Controls.Add(label5);
            Controls.Add(txtMinit);
            Controls.Add(label4);
            Controls.Add(txtLName);
            Controls.Add(label3);
            Controls.Add(txtFName);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "frmInsertarEmp";
            Text = "Agregar Empleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpHireDate;
        private Button btnAgregar;
        private Button btnCancelar;
        private Label label8;
        private TextBox txtPubId;
        private Label label7;
        private TextBox txtJlevel;
        private Label label6;
        private TextBox txtJId;
        private Label label5;
        private TextBox txtMinit;
        private Label label4;
        private TextBox txtLName;
        private Label label3;
        private TextBox txtFName;
        private Label label2;
        private TextBox txtID;
        private Label label1;
    }
}