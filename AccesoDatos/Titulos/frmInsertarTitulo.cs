using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos.Titulos
{
    public partial class frmInsertarTitulo : Form
    {
        public frmInsertarTitulo()
        {
            InitializeComponent();
        }

        private void btnAgregarTitulo_Click(object sender, EventArgs e)
        {
            try
            {
                Datos datos = new Datos();
                bool aggTitulo = datos.comando("insert into titles values('" +
                "" + txtIdT.Text.Replace("'","''") + "', '" + txtTitulo.Text.Replace("'","''")+ "', '" + txtTipo.Text.Replace("'","''") + "', '" +
                "" + txtPubId.Text + "'," + double.Parse(txtPrecio.Text) + "," + double.Parse(txtAnticipo.Text) +
                "," + double.Parse(txtRegalias.Text) + "," + int.Parse(txtVentas.Text) + ", '" + txtNotas.Text.Replace("'","''") + "'" +
                ", '" + dtpFechaPub.Value.Year + "-" + dtpFechaPub.Value.Month + "-" + dtpFechaPub.Value.Day + "')");

                if (aggTitulo)
                {
                    MessageBox.Show("Libro agregado correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al agregar el libro", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Valores no esperados\nAsegurse de no haber introducido letras en vez de numeros", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      
    }
}
