namespace Login_Parcial_Labo
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void txbnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            string mail = "maximo@gmial.com";
            string contrasenia = "11111";
            int confirmar = 1;


            if (confirmar == 1)
            {
                txbMail.Text = mail;
                txbPass.Text = contrasenia;
            }




        }
    }
}