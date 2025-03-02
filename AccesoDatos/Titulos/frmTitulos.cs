using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos.Titulos;

namespace AccesoDatos
{
    public partial class frmTitulos : Form
    {
        public frmTitulos()
        {
            InitializeComponent();
        }
        public void actualizarTitulos()
        {
            Datos datos = new Datos();
            DataSet dataSet = datos.consulta("select * from titles");

            if (dataSet != null)
            {
                dgvTitulos.DataSource = dataSet.Tables[0];
            }
        }
        private void frmTitulos_Load(object sender, EventArgs e)
        {
            actualizarTitulos();
        }

        private void dgvTitulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualizarTitulo titulo = new frmActualizarTitulo(dgvTitulos[0, e.RowIndex].Value.ToString(),
            dgvTitulos[1, e.RowIndex].Value.ToString(), dgvTitulos[2, e.RowIndex].Value.ToString(), dgvTitulos[3, e.RowIndex].Value.ToString(),
            dgvTitulos[4, e.RowIndex].Value.ToString(), dgvTitulos[5, e.RowIndex].Value.ToString(),
            dgvTitulos[6, e.RowIndex].Value.ToString(), dgvTitulos[7, e.RowIndex].Value.ToString(),
            dgvTitulos[8, e.RowIndex].Value.ToString(), dgvTitulos[9, e.RowIndex].Value.ToString());

            titulo.Show();
        }

        private void frmTitulos_Activated(object sender, EventArgs e)
        {
            actualizarTitulos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmInsertarTitulo aggTitulo = new frmInsertarTitulo();
            aggTitulo.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }
    }
}
