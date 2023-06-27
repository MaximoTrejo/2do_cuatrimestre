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
using IU.AlumnosFunciones;

namespace IU
{
    public partial class frmAlumno : Form
    {
        Persona miPersona;
        public frmAlumno()
        {
            InitializeComponent();
        }
        
        public frmAlumno(Persona persona):this()
        {
            miPersona = persona;
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            lblAlumno.Text = $"Bienvenido alumno {miPersona.Nombre} {miPersona.Apellido}";
        }

        private void btnInscripcionMateria_Click(object sender, EventArgs e)
        {
            fmrInscribirseMateria fmrInscribirseMateria = new fmrInscribirseMateria(miPersona);
            fmrInscribirseMateria.Show();
            this.Hide();
        }

        private void btnAsisMateria_Click(object sender, EventArgs e)
        {
            frmAsistencia frmAsistencia = new frmAsistencia(miPersona);
            frmAsistencia.Show();
            this.Hide();
        }

        private void btnEstadoAcademico_Click(object sender, EventArgs e)
        {
            fmrDatosAlumno fmrDatosAlumno = new fmrDatosAlumno(miPersona);
            fmrDatosAlumno.Show();
            this.Hide();
        }
    }
}
