using Saludo;


namespace Ejercicio_I01_Clase5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tboxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            //--------------------------------
            nombre = this.tboxNombre.Text;
            apellido = this.tBoxApellido.Text;

            FrmSaludar saludar = new FrmSaludar(nombre,apellido);
            saludar.Show();
            this.Hide();    
        }
    }
}