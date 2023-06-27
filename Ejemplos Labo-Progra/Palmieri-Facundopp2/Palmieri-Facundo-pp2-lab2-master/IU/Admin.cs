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
using IU.AdminFunciones;

namespace IU
{
    public partial class fmrAdmin : Form
    {
        Persona miPersona;
        public fmrAdmin()
        {
            InitializeComponent();
        }    
        public fmrAdmin(Persona persona):this()
        {
            this.miPersona = persona;
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
            m=0;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void fmrAdmin_Load(object sender, EventArgs e)
        {
            lblAdmin.Text = $"Bienvenido Administrador {miPersona.Nombre} {miPersona.Apellido}";
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            fmrAltaDeUsuarios frmAltaDeUsuario = new fmrAltaDeUsuarios(miPersona);
            frmAltaDeUsuario.Show();
            this.Hide();
        }

        private void btnAltaMateria_Click(object sender, EventArgs e)
        {
            fmrAltaDeMateria frmAltaDemateria = new fmrAltaDeMateria();
            frmAltaDemateria.ShowDialog();
            
        }

        private void btnAsigProf_Click(object sender, EventArgs e)
        {
            fmrAsigMateriaProf fmrAsigMateriaProf = new fmrAsigMateriaProf();
            fmrAsigMateriaProf.ShowDialog();
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            fmrCambiarEstado fmrCambiarEstado = new fmrCambiarEstado(miPersona);
            fmrCambiarEstado.Show();
            this.Hide();
        }

        private void btnAsignarAlumnoAMateria_Click(object sender, EventArgs e)
        {
            fmrInscribirAlumnoAMateria fmrInscribirAlumnoAMateria = new fmrInscribirAlumnoAMateria(miPersona);
            fmrInscribirAlumnoAMateria.Show();
            this.Hide();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            fmrExportarAlumno fmrExportarAlumno = new fmrExportarAlumno(miPersona);
            fmrExportarAlumno.Show();
            this.Hide();
        }
    }
}
