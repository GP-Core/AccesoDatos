using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos.Titulos
{
    public partial class frmActualizarTitulo : Form
    {
        public frmActualizarTitulo(string id, string titulo, string tipo,
            string pubId, string precio, string anticipo, string regalias,
            string ventas, string notas, string fechaPub)
        {
            InitializeComponent();
            txtIdT.Text = id;
            txtTitulo.Text = titulo;
            txtTipo.Text = tipo;
            txtPubId.Text = pubId;
            txtPrecio.Text = precio;
            txtAnticipo.Text = anticipo;
            txtRegalias.Text = regalias;
            txtVentas.Text = ventas;
            txtNotas.Text = notas;
            dtpFechaPub.Text = fechaPub;
        }

        private void btnActualizarTitulo_Click(object sender, EventArgs e)
        {
            try
            {
                Datos datos = new Datos();
                bool actTitulo = datos.comando("  update titles set title = '" + txtTitulo.Text.Replace("'", "''") +
                "', type = '" + txtTipo.Text.Replace("'", "''") + "', price =" + double.Parse(txtPrecio.Text =="" ?"0":txtPrecio.Text) + ", advance =" + double.Parse(txtAnticipo.Text == "" ? "0" : txtAnticipo.Text) +
                ", royalty = " + double.Parse(txtRegalias.Text== "" ?"0":txtRegalias.Text) + ",ytd_sales = " + int.Parse(txtVentas.Text == "" ? "0": txtVentas.Text) +
                ", notes= '" + txtNotas.Text.Replace("'", "''") + "', pubdate='" + dtpFechaPub.Value.Year + "-" + dtpFechaPub.Value.Month + "-" + dtpFechaPub.Value.Day +
                "'  where title_id = '" + txtIdT.Text + "'");

                if (actTitulo)
                {
                    MessageBox.Show("Titulo Actualizado Correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un problema al actualizar el sistema", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show("Haz introducido un valor no valido en los valores numericos", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool borrarTit = datos.comando(" delete from titles where title_id = '" + txtIdT.Text + "'");

            if (borrarTit)
            {
                MessageBox.Show("Titulo borrado correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al borrar el titulo", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
