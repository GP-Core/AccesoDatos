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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }
        private void actualizaGrid()
        {
            Datos datos = new Datos();
            DataSet dataSet = datos.consulta("select emp_id as ID , fname as [Frist Name], minit as Minit, lname as [Last Name], job_id as [Job ID], job_lvl as [Job Level], pub_id as [PUB ID], hire_date as [Hire date] from employee");

            if (dataSet != null)
            {
                dgvEmpleados.DataSource = dataSet.Tables[0];
            }
        }
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            actualizaGrid();
        }

        private void frmEmpleados_Activated(object sender, EventArgs e)
        {
            actualizaGrid();
        }



        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertarEmp insertarEmp = new frmInsertarEmp();
            insertarEmp.Show();
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualizarEmpleado empleadoAct = new frmActualizarEmpleado(dgvEmpleados[0, e.RowIndex].Value.ToString(),
           dgvEmpleados[1, e.RowIndex].Value.ToString(), dgvEmpleados[3, e.RowIndex].Value.ToString(),
           dgvEmpleados[2, e.RowIndex].Value.ToString(), dgvEmpleados[4, e.RowIndex].Value.ToString(),
           dgvEmpleados[5, e.RowIndex].Value.ToString(), dgvEmpleados[6, e.RowIndex].Value.ToString(), dgvEmpleados[7, e.RowIndex].Value.ToString());

            empleadoAct.Show();
        }

       
    }
}
