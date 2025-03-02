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
    public partial class frmInsertarEmp : Form
    {
        public frmInsertarEmp()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool aggEmp = datos.comando("insert into employee values ('"+txtID.Text+"'" +
                ",'"+txtFName.Text.Replace("'","''")+"','"+txtMinit.Text+"','"+txtLName.Text.Replace("'","''")+"','"+txtJId.Text+
                "','"+txtJlevel.Text+"','"+txtPubId.Text+"','"+dtpHireDate.Value.Year+"-"+dtpHireDate.Value.Month
                +"-"+dtpHireDate.Value.Day+"')");

            if (aggEmp)
            {
                MessageBox.Show("Empleado agregado correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al agregar el empleado\n favor de revisar datos", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
