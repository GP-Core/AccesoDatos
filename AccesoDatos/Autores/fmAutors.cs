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
    public partial class frmAuthors : Form
    {
        public frmAuthors()
        {
            InitializeComponent();
        }

        private void frmAuthors_Load(object sender, EventArgs e)
        {
            actualizaGrid();
        }


        private void frmAuthors_Activated(object sender, EventArgs e)
        {
            actualizaGrid();
        }

        private void actualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select au_id as ID,au_lname as [Last Name],au_fname as [Firts Name],phone as Phone,authors.address as Address,city as City,state as State,zip as Zip,contract as Contract From authors");

            if (ds != null)
            {
                dgvAutors.DataSource = ds.Tables[0];
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertar inse = new frmInsertar();
            inse.Show();
        }

        private void dgvAutors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualizarAutor actualiza = new frmActualizarAutor(dgvAutors[0, e.RowIndex].Value.ToString(), dgvAutors[1, e.RowIndex].Value.ToString(),
                                              dgvAutors[2, e.RowIndex].Value.ToString(), dgvAutors[3, e.RowIndex].Value.ToString(),
                                              dgvAutors[4, e.RowIndex].Value.ToString(), dgvAutors[5, e.RowIndex].Value.ToString(),
                                              dgvAutors[6, e.RowIndex].Value.ToString(), dgvAutors[7, e.RowIndex].Value.ToString(),
                                              Convert.ToBoolean(dgvAutors[8, e.RowIndex].Value));
            actualiza.Show();
        }
    }
}
