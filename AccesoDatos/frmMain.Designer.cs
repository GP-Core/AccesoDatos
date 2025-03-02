namespace AccesoDatos
{
    partial class frmMain
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
            menuStrip = new MenuStrip();
            autoresToolStripMenuItem1 = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { autoresToolStripMenuItem1, empleadosToolStripMenuItem, empleadosToolStripMenuItem1 });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(680, 38);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            menuStrip.MouseLeave += menuStrip_MouseLeave;
            menuStrip.MouseHover += menuStrip_MouseHover;
            // 
            // autoresToolStripMenuItem1
            // 
            autoresToolStripMenuItem1.AutoSize = false;
            autoresToolStripMenuItem1.BackColor = Color.FromArgb(96, 98, 96);
            autoresToolStripMenuItem1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoresToolStripMenuItem1.ForeColor = SystemColors.ButtonHighlight;
            autoresToolStripMenuItem1.Margin = new Padding(5, 2, 5, 2);
            autoresToolStripMenuItem1.Name = "autoresToolStripMenuItem1";
            autoresToolStripMenuItem1.Overflow = ToolStripItemOverflow.AsNeeded;
            autoresToolStripMenuItem1.Padding = new Padding(10, 5, 10, 5);
            autoresToolStripMenuItem1.Size = new Size(100, 30);
            autoresToolStripMenuItem1.Text = "AUTORES";
            autoresToolStripMenuItem1.Click += autoresToolStripMenuItem1_Click;
         
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.AutoSize = false;
            empleadosToolStripMenuItem.BackColor = Color.FromArgb(96, 98, 96);
            empleadosToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empleadosToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            empleadosToolStripMenuItem.Margin = new Padding(5, 2, 5, 2);
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Overflow = ToolStripItemOverflow.AsNeeded;
            empleadosToolStripMenuItem.Padding = new Padding(10, 5, 10, 5);
            empleadosToolStripMenuItem.Size = new Size(130, 30);
            empleadosToolStripMenuItem.Text = "EMPLEADOS";
            empleadosToolStripMenuItem.Click += titulosToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem1
            // 
            empleadosToolStripMenuItem1.AutoSize = false;
            empleadosToolStripMenuItem1.BackColor = Color.FromArgb(96, 98, 96);
            empleadosToolStripMenuItem1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empleadosToolStripMenuItem1.ForeColor = SystemColors.ButtonHighlight;
            empleadosToolStripMenuItem1.Margin = new Padding(5, 2, 5, 2);
            empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            empleadosToolStripMenuItem1.Overflow = ToolStripItemOverflow.AsNeeded;
            empleadosToolStripMenuItem1.Padding = new Padding(10, 5, 10, 5);
            empleadosToolStripMenuItem1.Size = new Size(100, 30);
            empleadosToolStripMenuItem1.Text = "TITULOS";
            empleadosToolStripMenuItem1.Click += tITULOSToolStripMenuItem1_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 382);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "frmMain";
            Text = "INICIO";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem autoresToolStripMenuItem1;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem1;
    }
}