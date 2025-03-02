namespace AccesoDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            bool f = obj.prueba();

            if (f)
            {
                MessageBox.Show("Conexion exitosa");
            }
            else
            {
                MessageBox.Show("Conexion no existosa");
            }
        }
    }
}
