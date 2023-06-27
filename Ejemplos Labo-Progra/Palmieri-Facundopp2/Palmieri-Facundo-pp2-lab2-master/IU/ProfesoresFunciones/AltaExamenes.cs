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
    public partial class fmrAltaExamenes : Form
    {
        Persona miPersona;

        public fmrAltaExamenes()
        {
            InitializeComponent();
        }
        public fmrAltaExamenes(Persona persona):this()
        {
            miPersona= persona;
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

        private void btnParcial_Click(object sender, EventArgs e)
        {
            Profesor auxProfe = (Profesor)miPersona;

            int auxIdProfe;
            int auxIdMateria;
            string auxNombreParcial;
            DateTime fechaParcial;
            Parcial auxParcial;

            if (validar())
            {
                auxIdMateria = ManejadorDeDatos.obtenerIdMateria(cmbMateria.Text);
                auxIdProfe = auxProfe.IdProf;
                auxNombreParcial = txtNombreParcial.Text;
                fechaParcial = mtcFechaParcial.SelectionStart;

                auxParcial = new Parcial(auxIdMateria, fechaParcial, auxNombreParcial, auxIdProfe);
                if(MessageBox.Show(auxParcial.mostrarParcial(),"¿Desea crear este parcial?",MessageBoxButtons.YesNo,MessageBoxIcon.Information)== DialogResult.Yes)
                {
                    if (ManejadorDeDatos.agregarUnParcial(auxParcial))
                    {
                        MessageBox.Show("Se creo el parcial correctamente","informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        limpiar();
                        cargarCmb();
                    }
                    else
                    {
                        MessageBox.Show("No se creo el parcial correctamente", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            else
            {
                MessageBox.Show("Le falta completar campos","error",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }

        private bool validar()
        {
            bool validar = false;
            if (cmbMateria.Text != null && cmbMateria is not null)
            {
                if (txtNombreParcial.Text is not null && txtNombreParcial.Text != "")
                {
                    if(mtcFechaParcial is not null)
                    {
                        validar = true;
                    }
                }
            }
            return validar;

        }


        private void cargarCmb()
        {
            Profesor auxProfe = (Profesor)miPersona;
            List<string> listMateria = ManejadorDeDatos.obtenerMateriaPorProfesor(auxProfe.IdProf);
            foreach (string materia in listMateria)
            {
                cmbMateria.Items.Add(materia);
            }
        }

        private void fmrAltaExamenes_Load(object sender, EventArgs e)
        {
            cargarCmb();
            this.mtcFechaParcial.MinDate = DateTime.Now;
        }

        public void limpiar()
        {
            txtNombreParcial.Text = null;
            cmbMateria.Items.Clear();
        }
    }
}
