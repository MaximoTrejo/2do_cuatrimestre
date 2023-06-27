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

namespace IU.AlumnosFunciones
{
    public partial class frmAsistencia : Form
    {
        Persona miPersona;
        public frmAsistencia()
        {
            InitializeComponent();
        }
        public frmAsistencia(Persona persona) : this()
        {
            miPersona = persona;
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

        private void fmrAsistencia_Load(object sender, EventArgs e)
        {
            lblAlumno.Text = $"Alumno {miPersona.Nombre} {miPersona.Apellido}";
            cargarCombo();
        }

        private void ptbAtras_Click(object sender, EventArgs e)
        {
            frmAlumno frmAlumno = new frmAlumno(miPersona);
            frmAlumno.Show();
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


        private void cargarCombo()
        {
            Alumno miAlumno = (Alumno)miPersona;
            List<string> listMaterias = new List<string>();
            listMaterias = ManejadorDeDatos.obtenerMateriaPorAlumno(miAlumno.Legajo);
            foreach (string item in listMaterias)
            {
                cmbMaterias.Items.Add(item);
            }
        }

        private void btnDarAsistencia_Click(object sender, EventArgs e)
        {
            Alumno miAlumno = (Alumno)miPersona;
            int idMateria;
            if (validar(cmbMaterias.Text))
            {
                idMateria = ManejadorDeDatos.obtenerIdMateria(cmbMaterias.Text);
                foreach (EstadoMateria item in miAlumno.Materias)
                {
                    if(item.IdMateria == idMateria)
                    {
                        if(item.Presente == false)
                        {
                            item.Presente = true;

                            List<EstadoMateria> estadoMateriasCursando = miAlumno.Materias;
                            estadoMateriasCursando.Remove(item);
                            
                            estadoMateriasCursando.Add(item);
                            miAlumno.Materias = estadoMateriasCursando;

                            ManejadorDeDatos.actualizarListaPersona(miAlumno);
                            MessageBox.Show("Dio el presente");
                            break;
                            // no esta guardando bien los datos
                        }
                        else
                        {
                            MessageBox.Show("ya dio el presente en esta materia");
                            break;

                        }
                    }
                }
            }
        }

        private bool validar(string materia)
        {
            bool validar = false;
            if (materia is not null && materia != "")
            {
                 validar = true;
            }
            else
            {
                MessageBox.Show("Falta completar a que materia quiere inscribirse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return validar;
        }


    }
}
