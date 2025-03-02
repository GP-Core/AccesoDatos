using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public partial class frmActualizarEmpleado : Form
    {
        public frmActualizarEmpleado(string id, string fname, string lname, string minit, string jobId,
                                    string joblevel, string pubId, string hireDate)
        {
            InitializeComponent();
            txtID.Text = id;
            txtFName.Text = fname;
            txtLName.Text = lname;
            txtMinit.Text = minit;
            txtJId.Text = jobId;
            txtJlevel.Text = joblevel;
            txtPubId.Text = pubId;
            dtpHireDate.Text = hireDate;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtMinit.Text = txtMinit.Text.Length > 1 ? txtMinit.Text.Substring(1, 1) : txtMinit.Text;

            Datos datos = new Datos();
            bool actEmp = datos.comando("update employee set fname = '" + txtFName.Text.Replace("'", "''") + "'," +
                "minit ='" + txtMinit.Text + "',lname ='" + txtLName.Text.Replace("'", "''") + "',job_id= '" + txtJId.Text +
                "', job_lvL ='" + txtJlevel.Text + "', pub_id= '" + txtPubId.Text + "', hire_date= '" + dtpHireDate.Value.Year + "-" +
                dtpHireDate.Value.Month + "-" + dtpHireDate.Value.Day + "' where emp_id = " +
                "'" + txtID.Text + "'");

            if (actEmp)
            {
                MessageBox.Show("Datos actualizados correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al actualizar datos", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Estas seguro de eliminar al empleado " + txtFName.Text + " " + txtLName.Text + "?",
                "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (res == DialogResult.OK)
            {
                Datos datos = new Datos();
                bool deleteEmp = datos.comando("delete  from employee where emp_id = '" + txtID.Text + "'");

                if (deleteEmp)
                {
                    MessageBox.Show("Empleado borrado correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar al empleado", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
