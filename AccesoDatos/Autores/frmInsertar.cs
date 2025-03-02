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
    public partial class frmInsertar : Form
    {
        public frmInsertar()
        {
            InitializeComponent();
        }

        private void frmInsertar_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("insert into authors values('" +
                    txtID.Text + " '," + "'" + txtLastName.Text.Replace("'", "''") + "'," +
                    "'" + txtNombre.Text.Replace("'", "''") + "'," + "'" + txtPhone.Text + "',"
                    + "'" + txtAddress.Text.Replace("'", "''") + "'," + "'" + txtCity.Text + "'," +
                    "'" + txtState.Text + "'," + "'" + txtZip.Text + "'," +
                    +(chbContract.Checked ? 1 : 0) + ")");
            if (f)
            {
                MessageBox.Show("Autor dado de alta correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Autor no dado de alta correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
