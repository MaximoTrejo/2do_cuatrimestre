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
using Entidades.Clases_dab;

namespace IU.AdminFunciones
{
    public partial class fmrAsigMateriaProf : Form
    {
        public fmrAsigMateriaProf()
        {
            InitializeComponent();
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

        private void CargaComboBox()
        {
            List<string> listMaterias = new List<string>();
            List<string> listProfesores = new List<string>();

            listMaterias = ManejadorDeDatos.obtenerMaterias();
            listProfesores = ManejadorDeDatos.obtenerProfesores();

            foreach (string item in listMaterias)
            {
                cmbMaterias.Items.Add(item);
            }
            foreach (string item in listProfesores)
            {
                cmbProfesores.Items.Add(item);
            }

        }

        private void fmrAsigMateriaProf_Load(object sender, EventArgs e)
        {
            CargaComboBox();
        }


        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }
        private void btnAsignarMateriaAlProfe_Click(object sender, EventArgs e)
        {
            string auxProfe;
            string auxNombreMateria;
            int auxIdMateria;
            int auxIdProfe;
            

            if (cmbProfesores.Text is not null && cmbProfesores.Text != "")
            {

                if (cmbMaterias.Text is not null && cmbMaterias.Text != "")
                {
                    auxNombreMateria = cmbMaterias.Text;
                    auxProfe = cmbProfesores.Text;
                    auxIdMateria = ManejadorDeDatos.obtenerIdMateria(auxNombreMateria);
                    auxIdProfe = ManejadorDeDatos.obtenerIdProfesor(auxProfe);


                   if(ManejadorDeDatos.actualizarMateriaEnLista(auxIdMateria, auxIdProfe))
                    {
                        MessageBox.Show("Se agrego", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ProfesEnMateriaDAB.AddProfesEnMateria(auxIdMateria, auxIdProfe);
                    }
                    else
                    {
                        MessageBox.Show("Ese profesor ya esta en esa materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Falta completar la materia", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                MessageBox.Show("Falta completar a que el profesor","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
            limpiar();
            CargaComboBox();
        }


        public void limpiar()
        {
            cmbMaterias.Items.Clear();
            cmbProfesores.Items.Clear();
        }


    }
}
