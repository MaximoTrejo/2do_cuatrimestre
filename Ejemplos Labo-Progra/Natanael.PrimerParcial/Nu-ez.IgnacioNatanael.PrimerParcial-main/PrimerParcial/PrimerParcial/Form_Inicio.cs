using Entidades;

namespace PrimerParcial
{
    public partial class Form_Inicio : Form
    {
        //DECLARO ATRIBUTO
        private Usuario usuarioActivo; // constante estatica universal
        public Form_Inicio(Usuario usuarioAct)
        {
            // Forms
            InitializeComponent();
            Bitmap img = new Bitmap(Environment.CurrentDirectory + @"\img\background01.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //

            usuarioActivo = usuarioAct;
           // MessageBox.Show(usuarioActivo.nombre + " g1");

            NombreUsuarioActivo.Text = usuarioActivo.nombre;
        }

        public void Form_Inicio_Load(object sender, System.EventArgs e)
        {
            switch (usuarioActivo.perfil) // Tener en cuenta el formato de Json
            {
                case "administrador":
                    break;
                case "supervisor":
                    break;
                case "vendedor":
                    break;
            }
        }

    private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (usuarioActivo.perfil != "vendedor")
            {
                MessageBox.Show("Exclusivo para Vendedores");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e) // ABM PASAJEROS
        {
            if (usuarioActivo.perfil != "vendedor")
            {
                MessageBox.Show("Exclusivo para Vendedores");
                return;
            }
        }

        private void NombreUsuarioActivo_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /* if (usuarioActivo.perfil != "vendedor" && usuarioActivo.perfil != "supervisor")
             {
                 MessageBox.Show("Exclusivo para Vendedores y Supervisores");
                 return;
             }*/

            Form_ABMPasajero formViajes = new Form_ABMPasajero(); // Preparamos siguiente panel
            formViajes.StartPosition = FormStartPosition.CenterParent;
            formViajes.Show(this);

            // desabilitadmos temporalmente
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
        }

        private void buttonMDViajes_Click(object sender, EventArgs e)
        {
            if (usuarioActivo.perfil != "administrador")
            { 
                MessageBox.Show("Exclusivo para Administradores");
                return;
            }

            Form_ABMViajes formViajes = new Form_ABMViajes(); // Preparamos siguiente panel
            formViajes.StartPosition = FormStartPosition.CenterParent;
            formViajes.Show(this);

            // desabilitadmos temporalmente
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
        }

        private void buttonMDAeronaves_Click(object sender, EventArgs e)
        {
            if (usuarioActivo.perfil != "administrador")
            {
                MessageBox.Show("Exclusivo para Administradores");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (usuarioActivo.perfil != "vendedor")
            {
                MessageBox.Show("Exclusivo para Vendedores");
                return;
            }
        }

        private void Form_Inicio_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}