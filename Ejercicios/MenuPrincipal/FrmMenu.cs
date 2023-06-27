namespace MenuPrincipal
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()//constructor
        {
            InitializeComponent();
            //lblSaludos.Text = "Hola Saludos";
        }

        //sobrecarga de constructor que recibe un usuario
        public FrmMenu(string usuario) : this()
        {
            lblSaludos.Text = $"Hola {usuario}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}