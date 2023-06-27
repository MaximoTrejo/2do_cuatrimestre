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
using Entidades.Interface;
using Entidades.Serializacion;

namespace IU.AdminFunciones
{
    public partial class fmrExportarAlumno : Form
    {
        Admin miPersona;
        List<Alumno> alumnos;
        JSON<List<Alumno>> serializadorAlumno;
        Csv serializadorAlumnoCsv;

        public fmrExportarAlumno()
        {
            InitializeComponent();
            this.serializadorAlumno = new JSON<List<Alumno>>(IArchivo<List<Alumno>>.ETipoArchivo.JSON);
            serializadorAlumnoCsv = new Csv();
        }

        public fmrExportarAlumno(Persona persona) : this()
        {
            miPersona = (Admin)persona;
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
            fmrAdmin fmrAdmin = new fmrAdmin(miPersona);
            fmrAdmin.Show();
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

        private void fmrExportarAlumno_Load(object sender, EventArgs e)
        {
            cargaLista();
        }
        private void cargaLista()
        {
            List<string> lista = ManejadorDeDatos.obtenerMaterias();

            foreach (string materia in lista)
            {
                cmbMateria.Items.Add(materia);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string path= txtNombreArchivo.Text;
            string materia = cmbMateria.Text;
            string ubicacion="no se guardo";
            if(materia is not null && path is not null)
            {
                if (rdbJson.Checked == true)
                {

                    ubicacion= serializadorAlumno.Escribir(alumnos, path);

                }
                else if(rdbCsv.Checked == true)
                {
                    ubicacion = serializadorAlumnoCsv.guardar(alumnos, path);

                }
            }
            if(ubicacion != "no se guardo")
            {
                MessageBox.Show($"el archivo se guardo en\n {ubicacion}");

            }


        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idMateriaAux = -1;
            idMateriaAux = ManejadorDeDatos.obtenerIdMateria(cmbMateria.Text);
            alumnos = ManejadorDeDatos.obtenerAlumnosTodosDatosPorMateria(idMateriaAux);
        }
    }
}
