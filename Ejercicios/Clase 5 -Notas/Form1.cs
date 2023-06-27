using MenuPrincipal;

namespace Clase_5__Notas
{
    public partial class Form1 : Form
    {
        public Form1()//los formularios son objetos 
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //usuario lucas
            //pass 123
            string usuario;
            string pass;
            //--------------------------------
            usuario = this.usuario.Text;
            pass = this.pass.Text;

            //varido
            if (usuario == "maxi" && pass == "123")
            {
                //creo una forma de la solucion y como hice una sobrecarga le puedo pasar el nombre de usuario
                FrmMenu menu = new FrmMenu(usuario);
                menu.Show();//una forma de mostrarlo
                //cerrar la ventana 
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario Invalido");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
            {
                pass.PasswordChar = '0';
            }
            else
            {
                pass.PasswordChar = '*';
            }

        }
    }
}