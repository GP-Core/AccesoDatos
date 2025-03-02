namespace AccesoDatos
{
    partial class frmInsertar
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
            btnCancelar = new Button();
            btnAgregar = new Button();
            chbContract = new CheckBox();
            txtZip = new TextBox();
            label8 = new Label();
            txtState = new TextBox();
            label7 = new Label();
            txtCity = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(671, 389);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 34);
            btnCancelar.TabIndex = 38;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(543, 394);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 37;
            btnAgregar.Text = "INSERTAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // chbContract
            // 
            chbContract.AutoSize = true;
            chbContract.Location = new Point(34, 380);
            chbContract.Name = "chbContract";
            chbContract.Size = new Size(87, 24);
            chbContract.TabIndex = 36;
            chbContract.Text = "Contract";
            chbContract.UseVisualStyleBackColor = true;
            // 
            // txtZip
            // 
            txtZip.Location = new Point(456, 301);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(149, 27);
            txtZip.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(456, 278);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 34;
            label8.Text = "ZIP code";
            // 
            // txtState
            // 
            txtState.Location = new Point(263, 301);
            txtState.Name = "txtState";
            txtState.Size = new Size(149, 27);
            txtState.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(263, 278);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 32;
            label7.Text = "State";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(34, 301);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(149, 27);
            txtCity.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 278);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 30;
            label6.Text = "City";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(292, 200);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(345, 27);
            txtAddress.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(292, 177);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 28;
            label5.Text = "Address";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(34, 200);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(193, 27);
            txtPhone.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 177);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 26;
            label4.Text = "Phone";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(433, 120);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(345, 27);
            txtLastName.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 97);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 24;
            label3.Text = "Last Name";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(34, 120);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(305, 27);
            txtNombre.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 97);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 22;
            label2.Text = "Frist Name";
            // 
            // txtID
            // 
            txtID.Location = new Point(23, 50);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 20;
            label1.Text = "ID";
            // 
            // frmInsertar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(chbContract);
            Controls.Add(txtZip);
            Controls.Add(label8);
            Controls.Add(txtState);
            Controls.Add(label7);
            Controls.Add(txtCity);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "frmInsertar";
            Text = "frmInsertar";
            Load += frmInsertar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnAgregar;
        private CheckBox chbContract;
        private TextBox txtZip;
        private Label label8;
        private TextBox txtState;
        private Label label7;
        private TextBox txtCity;
        private Label label6;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtID;
        private Label label1;
    }
}