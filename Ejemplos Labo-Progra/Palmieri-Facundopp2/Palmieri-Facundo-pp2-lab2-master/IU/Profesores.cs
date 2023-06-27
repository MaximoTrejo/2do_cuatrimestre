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
using IU.ProfesoresFunciones;


namespace IU
{
    public partial class frmProfesores : Form
    {
        Persona miPersona;
        public frmProfesores()
        {
            InitializeComponent();
        }     
        public frmProfesores(Persona persona):this ()
        {
            miPersona = persona;
        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

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



        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void frmProfesores_Load(object sender, EventArgs e)
        {
            lblProfesor.Text = $"Bienvenido Profesor {miPersona.Nombre} {miPersona.Apellido}";
        }

        private void btnCrearParcial_Click(object sender, EventArgs e)
        {
            fmrAltaExamenes fmrAltaExamenes = new fmrAltaExamenes(miPersona);
            fmrAltaExamenes.Show();
            this.Hide();
        }

        private void btnPonerNota_Click(object sender, EventArgs e)
        {
            fmrPonerNota fmrPonerNota = new fmrPonerNota(miPersona);
            fmrPonerNota.Show();
            this.Hide();
        }

        private void btnVerMateria_Click(object sender, EventArgs e)
        {
            fmrDatosProfesores fmrDatosProfe = new fmrDatosProfesores(miPersona);
            fmrDatosProfe.Show();
            this.Hide();
        }
    }
}
