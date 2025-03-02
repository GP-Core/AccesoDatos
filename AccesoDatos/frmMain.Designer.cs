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
            titulosToolStripMenuItem = new ToolStripMenuItem();
            tITULOSToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { autoresToolStripMenuItem1, titulosToolStripMenuItem, tITULOSToolStripMenuItem1 });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // autoresToolStripMenuItem1
            // 
            autoresToolStripMenuItem1.Name = "autoresToolStripMenuItem1";
            autoresToolStripMenuItem1.Size = new Size(86, 24);
            autoresToolStripMenuItem1.Text = "AUTORES";
            autoresToolStripMenuItem1.Click += autoresToolStripMenuItem1_Click;
            // 
            // titulosToolStripMenuItem
            // 
            titulosToolStripMenuItem.Name = "titulosToolStripMenuItem";
            titulosToolStripMenuItem.Size = new Size(107, 24);
            titulosToolStripMenuItem.Text = "EMPLEADOS";
            titulosToolStripMenuItem.Click += titulosToolStripMenuItem_Click;
            // 
            // tITULOSToolStripMenuItem1
            // 
            tITULOSToolStripMenuItem1.Name = "tITULOSToolStripMenuItem1";
            tITULOSToolStripMenuItem1.Size = new Size(78, 24);
            tITULOSToolStripMenuItem1.Text = "TITULOS";
            tITULOSToolStripMenuItem1.Click += tITULOSToolStripMenuItem1_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private ToolStripMenuItem titulosToolStripMenuItem;
        private ToolStripMenuItem tITULOSToolStripMenuItem1;
    }
}