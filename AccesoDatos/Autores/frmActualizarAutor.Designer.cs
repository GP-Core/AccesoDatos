namespace AccesoDatos
{
    partial class frmActualizarAutor
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
            txtNombre = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtCity = new TextBox();
            label6 = new Label();
            txtState = new TextBox();
            label7 = new Label();
            txtZip = new TextBox();
            label8 = new Label();
            chbContract = new CheckBox();
            btnActualizar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 39);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(23, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(305, 27);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 86);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Frist Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(422, 109);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(345, 27);
            txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(422, 86);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(23, 189);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(193, 27);
            txtPhone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 166);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "Phone";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(281, 189);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(345, 27);
            txtAddress.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 166);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 8;
            label5.Text = "Address";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(23, 290);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(149, 27);
            txtCity.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 267);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 10;
            label6.Text = "City";
            // 
            // txtState
            // 
            txtState.Location = new Point(252, 290);
            txtState.Name = "txtState";
            txtState.Size = new Size(149, 27);
            txtState.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(252, 267);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 12;
            label7.Text = "State";
            // 
            // txtZip
            // 
            txtZip.Location = new Point(445, 290);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(149, 27);
            txtZip.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(445, 267);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 14;
            label8.Text = "ZIP code";
            // 
            // chbContract
            // 
            chbContract.AutoSize = true;
            chbContract.Location = new Point(23, 369);
            chbContract.Name = "chbContract";
            chbContract.Size = new Size(87, 24);
            chbContract.TabIndex = 16;
            chbContract.Text = "Contract";
            chbContract.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(532, 383);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(660, 378);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 34);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(407, 383);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmActualizarAutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
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
            Name = "frmActualizarAutor";
            Text = "Actualizar Autor";
            Load += frmActualizarAutor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtCity;
        private Label label6;
        private TextBox txtState;
        private Label label7;
        private TextBox txtZip;
        private Label label8;
        private CheckBox chbContract;
        private Button btnActualizar;
        private Button btnCancelar;
        private Button btnEliminar;
    }
}