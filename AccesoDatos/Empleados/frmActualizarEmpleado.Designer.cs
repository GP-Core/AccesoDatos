namespace AccesoDatos
{
    partial class frmActualizarEmpleado
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
            label1 = new Label();
            txtID = new TextBox();
            txtFName = new TextBox();
            label2 = new Label();
            txtLName = new TextBox();
            label3 = new Label();
            txtMinit = new TextBox();
            label4 = new Label();
            txtJId = new TextBox();
            label5 = new Label();
            txtJlevel = new TextBox();
            label6 = new Label();
            txtPubId = new TextBox();
            label7 = new Label();
            label8 = new Label();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnActualizar = new Button();
            dtpHireDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(26, 67);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 1;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(26, 159);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(245, 27);
            txtFName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 122);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Frist Name";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(492, 159);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(245, 27);
            txtLName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(492, 122);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // txtMinit
            // 
            txtMinit.Location = new Point(325, 159);
            txtMinit.Name = "txtMinit";
            txtMinit.Size = new Size(100, 27);
            txtMinit.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 122);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 6;
            label4.Text = "Minit";
            // 
            // txtJId
            // 
            txtJId.Location = new Point(26, 261);
            txtJId.Name = "txtJId";
            txtJId.Size = new Size(104, 27);
            txtJId.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 238);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 8;
            label5.Text = "Job ID";
            // 
            // txtJlevel
            // 
            txtJlevel.Location = new Point(178, 261);
            txtJlevel.Name = "txtJlevel";
            txtJlevel.Size = new Size(104, 27);
            txtJlevel.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 238);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 10;
            label6.Text = "Job Level";
            // 
            // txtPubId
            // 
            txtPubId.Location = new Point(335, 261);
            txtPubId.Name = "txtPubId";
            txtPubId.Size = new Size(104, 27);
            txtPubId.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(335, 238);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 12;
            label7.Text = "Pub ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(473, 238);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 14;
            label8.Text = "Hire Date";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(168, 390);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 29);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(473, 390);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 29);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "CERRAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(325, 390);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(114, 29);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(473, 270);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(281, 27);
            dtpHireDate.TabIndex = 19;
            // 
            // frmActualizarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpHireDate);
            Controls.Add(btnActualizar);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
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
            Name = "frmActualizarEmpleado";
            Text = "ACTUALIZACION DE DATOS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtFName;
        private Label label2;
        private TextBox txtLName;
        private Label label3;
        private TextBox txtMinit;
        private Label label4;
        private TextBox txtJId;
        private Label label5;
        private TextBox txtJlevel;
        private Label label6;
        private TextBox txtPubId;
        private Label label7;
        private Label label8;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnActualizar;
        private DateTimePicker dtpHireDate;
    }
}