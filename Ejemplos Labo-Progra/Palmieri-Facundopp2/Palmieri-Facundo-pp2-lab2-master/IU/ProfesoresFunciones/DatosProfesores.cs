using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace IU.ProfesoresFunciones
{
    public partial class fmrDatosProfesores : Form
    {
       Profesor miPersona;
        public fmrDatosProfesores()
        {
            InitializeComponent();
        }
        public fmrDatosProfesores(Persona persona):this()
        {
            miPersona = (Profesor)persona;
        }

        public int m;
        public int mx;
        public int my;
        private void pnlBordeSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void pnlBordeSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pnlBordeSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void ptbAtras_Click(object sender, EventArgs e)
        {
            frmProfesores frmProfesores = new frmProfesores(miPersona);
            frmProfesores.Show();
            this.Hide();
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void fmrDatosProfesores_Load(object sender, EventArgs e)
        {
            cargarDatos();
            cargaRtbConEstadoDelasMaterias();
        }
        private void cargarDatos()
        {
            lblApellido.Text += miPersona.Apellido;
            lblNombre.Text += miPersona.Nombre;
            lblDni.Text += miPersona.Dni;
        }

        private void cargaRtbConEstadoDelasMaterias()
        {
            int idMateria;
            List<string> listaMateriaProfe = ManejadorDeDatos.obtenerMateriaPorProfesor(miPersona.IdProf);
            List<string> listaDeAlumno; 
           
            StringBuilder sb = new StringBuilder();

            foreach (string materia in listaMateriaProfe)
            {
                sb.AppendLine(materia);
                idMateria = ManejadorDeDatos.obtenerIdMateria(materia);
                listaDeAlumno = ManejadorDeDatos.obtenerAlumnosPorMateria(idMateria);
                foreach (string alumno in listaDeAlumno)
                {
                    sb.AppendLine(alumno);
                }
                sb.AppendLine("-------------------------------------------------------------------------");
            }
            rtbDatosMateria.Text = sb.ToString();
        }


    }
}
