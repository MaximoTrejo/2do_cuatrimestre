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
    public partial class fmrAltaDeMateria : Form
    {
        public fmrAltaDeMateria()
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
        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmrAltaDeMateria_Load(object sender, EventArgs e)
        {
            rdbNo.Checked = true;
            CargaComboBox();
        }
        private void CargaComboBox()
        {
            List<string> listMaterias = new List<string>();
            List<string> listProfesores = new List<string>();



            listMaterias = ManejadorDeDatos.obtenerMaterias();
            foreach (string item in listMaterias)
            {
                cmbMateria.Items.Add(item);
            }
            cmbMateria.SelectedIndex = 0;

            listProfesores = ManejadorDeDatos.obtenerProfesores();
            foreach (string item in listProfesores)
            {
                cmbProfesores.Items.Add(item);
            }
            cmbProfesores.SelectedIndex = 0;

            cmbCuatri.DataSource = Enum.GetValues(typeof(eCuatri));
        }
        private void LimpiarComboBox()
        {
            cmbMateria.Items.Clear();
        }

        private void btnCrearMateria_Click(object sender, EventArgs e)
        {
            string nombreMateria ;
            string auxNombre="a";
            string nombreProfesor="a";
            int auxIdCorrelativa=-1;
            List<int> idProfesor = new List<int>();
            eCuatri cuatri =eCuatri.Curso_Ingreso ;

            if (rdbNo.Checked == true)
            {
                auxIdCorrelativa = -1;
            }
            else if (rdbSi.Checked == true)
            {
                if (cmbMateria.Text is not null && cmbMateria.Text != "")
                {
                    nombreMateria = cmbMateria.Text;
                    auxIdCorrelativa = ManejadorDeDatos.numCorrelativa(nombreMateria);
                }
                else
                {
                    MessageBox.Show("Falta completar a que materia es correlativa");
                }
            }


            if (txtNombre.Text is not null && txtNombre.Text != "")
            {
                auxNombre = txtNombre.Text;
                if (cmbCuatri.Text is not null && cmbCuatri.Text != "")
                {
                    if (cmbProfesores.Text is not null && cmbProfesores.Text != "") 
                    {
                        nombreProfesor = cmbProfesores.Text;
                        idProfesor.Add(ManejadorDeDatos.obtenerIdProfesor(nombreProfesor));
                    }
                    cuatri = SaberCuatri(cmbCuatri.Text);
                }
                else
                {
                     MessageBox.Show("Falta completar de que cuatrimestre pertenece la materia");
                }
            }
            else
            {
                MessageBox.Show("Falta completar el nombre");
            }

            Materia nuevaMateria = new Materia(auxIdCorrelativa, auxNombre, cuatri, idProfesor);
            if (MessageBox.Show(nuevaMateria.MostrarDatos(), "¿Desea crear esta materia?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                MessageBox.Show("creado");
                ManejadorDeDatos.CargarMateriaEnLista(nuevaMateria);
               MateriasDAB.AddMateria(nuevaMateria.IdMateria,auxNombre,Convert.ToInt32(cuatri),auxIdCorrelativa);


                LimpiarComboBox();
                CargaComboBox();

            }
            else
            {
                MessageBox.Show("no creado");
            }

            limpiar();
            CargaComboBox();
        }

        private void rdbSi_CheckedChanged(object sender, EventArgs e)
        {
            cmbMateria.Visible = true;
        }

        private void rdbNo_CheckedChanged(object sender, EventArgs e)
        {
            cmbMateria.Visible =false;

        }


        private eCuatri SaberCuatri(string cuatri)
        {
            eCuatri queCuatri= eCuatri.Curso_Ingreso;

            switch (cuatri)
            {
                case "Curso_Ingreso":
                    queCuatri = eCuatri.Curso_Ingreso;
                    break;
                case "Primer_Cuatri":
                    queCuatri = eCuatri.Primer_Cuatri;
                    break;
                case "Segundo_Cuatri":
                    queCuatri = eCuatri.Segundo_Cuatri;
                    break;
                case "Tercer_Cuatri":
                    queCuatri = eCuatri.Tercer_Cuatri;
                    break;
                case "Cuarto_Cuatri":
                    queCuatri = eCuatri.Cuarto_Cuatri;
                    break;
            }

            return queCuatri;
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    
        public void limpiar()
        {
            txtNombre.Clear();
            rdbNo.Checked = false;
            rdbSi.Checked = false;
            cmbProfesores.Items.Clear();
            cmbMateria.Items.Clear();
            cmbMateria.Visible = false;
        }
    
    }
}
