using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void autoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAuthors autores = new frmAuthors();
            autores.Show();
            this.Hide();
        }

        private void titulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            empleados.Show();
            this.Hide();
        }

        private void tITULOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTitulos titulos = new frmTitulos();
            titulos.Show();
            this.Hide();
        }

        private void menuStrip_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void menuStrip_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

     
    }
}
