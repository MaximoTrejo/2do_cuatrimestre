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
    public partial class fmrInscribirseMateria : Form
    {
        Persona miPersona;
        public fmrInscribirseMateria()
        {
            InitializeComponent();
        }

        public fmrInscribirseMateria(Persona miPersona) : this()
        {
            this.miPersona = miPersona;
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

        private void CargaComboBox()
        {
            List<string> listMaterias = new List<string>();

            listMaterias = ManejadorDeDatos.obtenerMaterias();

            foreach (string item in listMaterias)
            {
                cmbMaterias.Items.Add(item);
            }


        }

        private void fmrInscribirseMateria_Load(object sender, EventArgs e)
        {
            CargaComboBox();
        }



        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idMateriaAux = -1;
            idMateriaAux = ManejadorDeDatos.obtenerIdMateria(cmbMaterias.Text);
            List<int> listaProfesores = ManejadorDeDatos.obtenerIdProfesoresDeUnaMateria(idMateriaAux);
            cmbProfesores.Items.Clear();
            List<string> listaProfesoresNombre = ManejadorDeDatos.obtenerNombreDeProfesoresPorIdProfe(listaProfesores);
            foreach (string item in listaProfesoresNombre)
            {
                cmbProfesores.Items.Add(item);
            }
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            EstadoMateria auxEstadoMateria;
            Alumno auxAlumno = (Alumno)miPersona;

            string nombreMateria ;
            int idMateria;

            string nombreProfesor ;

            if (validar(cmbMaterias.Text, cmbProfesores.Text))
            {
                nombreMateria = cmbMaterias.Text;
                nombreProfesor = cmbProfesores.Text;
                idMateria = ManejadorDeDatos.obtenerIdMateria(nombreMateria);
                if (ManejadorDeDatos.EstaEnLaMateria(auxAlumno, idMateria))
                {
                    if (auxAlumno.CantMateriasDando < 2)
                    {
                        auxEstadoMateria = new EstadoMateria(idMateria,  eEstado.Cursando);

                        auxAlumno.CantMateriasDando++;
                        List<EstadoMateria> estadoMateriasCursando = auxAlumno.Materias;
                        estadoMateriasCursando.Add(auxEstadoMateria);

                        if (ManejadorDeDatos.DioLaCorrelativa(estadoMateriasCursando, idMateria) == true) {
                            
                             auxAlumno.Materias = estadoMateriasCursando;

                            ManejadorDeDatos.actualizarListaPersona(auxAlumno);
                                
                            ManejadorDeDatos.actualizarListaMateria(auxAlumno, idMateria);

                            MessageBox.Show("Se inscribio correctamente a la materia", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No dio la materia correlativa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }    
                    }
                    else
                    {
                        MessageBox.Show("Ya esta inscripto a la maxima cantidad de materias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ya esta inscripto en esa materias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private bool validar(string materia, string profesor)
        {
            bool validar = false;
            if (materia is not null && materia != "")
            {
                if (profesor is not null && profesor != "")
                {
                    validar = true;
                }
                else
                {
                    MessageBox.Show("Falta completar el profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Falta completar a que materia quiere inscribirse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return validar;
        }

    }
}
