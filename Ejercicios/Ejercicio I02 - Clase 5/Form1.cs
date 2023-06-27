using Ingresante;
using Genero_Cursos;

namespace Ejercicio_I02___Clase_5
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            int edad;
            string pais;
            string Genero;
            string cursos;

            nombre = this.txtBNombre.Text;
            apellido = this.txtbApellido.Text;
            edad = (int)this.nudEdad.Value;
            pais = this.lbxPaises.Text;


            Class1 genero = new Class1();

            Genero = genero.Generos(rbnMasculino.Checked, rbnFemenino.Checked);

            cursos = genero.Cursos(chbCsharp.Checked, chbCmas.Checked);

            //string cursos ,string direccion , int edad, string genero,string nombre,string pais
            ingresante ingresante = new ingresante(cursos, apellido, edad, Genero, nombre, pais);

            MessageBox.Show(ingresante.Mostrar());

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nudEdad_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}