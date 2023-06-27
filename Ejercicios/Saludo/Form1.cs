namespace Saludo
{
    public partial class FrmSaludar : Form
    {
        public FrmSaludar()
        {
            InitializeComponent();
        }

        public FrmSaludar(string usuario, string apellido) : this()
        {
            lblSaludar.Text = $"Hola {usuario} {apellido}";
        }

        private void FrmSaludar_Load(object sender, EventArgs e)
        {

        }
    }
}