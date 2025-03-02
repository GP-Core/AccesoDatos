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
    public partial class frmActualizarAutor : Form
    {
        public frmActualizarAutor(string id, string lname, string fname,
            string phone, string address, string city, string state, string zip,
            bool contract)
        {
            InitializeComponent();
            txtID.Text = id;
            txtNombre.Text = fname;
            txtLastName.Text = lname;
            txtPhone.Text = phone;
            txtAddress.Text = address;
            txtCity.Text = city;
            txtState.Text = state;
            txtZip.Text = zip;
            chbContract.Checked = contract;
        }

        private void frmActualizarAutor_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("update authors set " +
                                   "au_fname = '" + txtNombre.Text.Replace("'","''") +
                                   "', au_lname = '" + txtLastName.Text.Replace("'","''") +
                                   "', phone = '" + txtPhone.Text +
                                   "', address = '" + txtAddress.Text.Replace("'","''")+
                                   "', city = '" + txtCity.Text.Replace("'","''") +
                                   "', state = '" + txtState.Text +
                                   "', zip = '" + txtZip.Text +
                                   "', contract = " + (chbContract.Checked ? 1 : 0) +
                                   " where au_id = '" + txtID.Text + "'");

            if (f)
            {
                MessageBox.Show("AUTOR ACTUALIZADO", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("AUTOR NO ACTUALIZADO", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro de eliminar el registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("delete from authors where au_id = '" + txtID.Text + "'");
                if (f) {
                    MessageBox.Show("AUTOR ELIMINADO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error De Sistema", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
