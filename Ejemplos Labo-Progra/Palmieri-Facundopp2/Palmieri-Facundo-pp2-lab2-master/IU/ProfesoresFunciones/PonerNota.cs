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
    public partial class fmrPonerNota : Form
    {
        Profesor miPersona;

        public fmrPonerNota()
        {
            InitializeComponent();
        }

        public fmrPonerNota(Persona persona):this()
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

        private void fmrPonerNota_Load(object sender, EventArgs e)
        {
            cargaLista();
        }

        private void cargaLista()
        {
            List<string> lista = ManejadorDeDatos.obtenerMateriaPorProfesor(miPersona.IdProf);

            foreach (string materia in lista)
            {
                cmbMateria.Items.Add(materia);
            }
        }


        /// <summary>
        /// Funcion para cuando selecione un elemento del combo box le carga en el combo box de  parciales de esa materia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idMateriaAux = -1;
            int idProfe = miPersona.IdProf;
            idMateriaAux = ManejadorDeDatos.obtenerIdMateria(cmbMateria.Text);
            List<string> listaParciales = ManejadorDeDatos.obtenerNombresParciales(idMateriaAux, idProfe);
            cmbNombreParcial.Items.Clear();
            foreach (string item in listaParciales)
            {
                cmbNombreParcial.Items.Add(item);
            }
        }

        /// <summary>
        /// Funcion para cuando selecione un elemento del combo box le carga en el combo box de  alumnos solamente los alumnos que pueden dar ese parcial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNombreParcial_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idMateriaAux = -1;
            idMateriaAux = ManejadorDeDatos.obtenerIdMateria(cmbMateria.Text);
            List<int> listaAlumno = ManejadorDeDatos.obtenerAlumnosPorIdMateria(idMateriaAux);
            cmbAlumno.Items.Clear();
            List<string> listaAlumnosNombre = ManejadorDeDatos.obtenerNombreDeAlumnosPorSuLegajo(listaAlumno);
            foreach (string item in listaAlumnosNombre)
            {
                cmbAlumno.Items.Add(item);
            }
            if (listaAlumnosNombre.Count == 0)
            {
                cmbAlumno.Items.Clear();
            }
        }

        /// <summary>
        /// Funcion para poner la nota si todos los campos estan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPonerNota_Click(object sender, EventArgs e)
        {
            int idParcial;
            int idMateria;
            int idAlumno;
            float nota = (float)0;
            EstadoMateria nuevoEstado;
            if(txtNota.Text is not null && float.TryParse(txtNota.Text, out nota))
            {
                if (nota <= 10 && nota >= 0)
                {
                    if (cmbNombreParcial.Text is not null && cmbNombreParcial.Text != "")
                    {


                        if (cmbMateria.Text is not null && cmbMateria.Text != "")
                        {
                            if (cmbAlumno.Text is not null && cmbAlumno.Text != "")
                            {
                                idMateria = ManejadorDeDatos.obtenerIdMateria(cmbMateria.Text);
                                idParcial = ManejadorDeDatos.obtenerIdParcialPorNombre(cmbNombreParcial.Text, idMateria);
                                idAlumno = ManejadorDeDatos.ObtenerLegajoPorNombre(cmbAlumno.Text);
                                nuevoEstado = ManejadorDeDatos.obtenerEstadoMateria(idMateria, idAlumno);
                                switch (saberParcial())
                                {
                                    case "Primer parcial":
                                        nuevoEstado.IdParcialUno = idParcial;
                                        nuevoEstado.NotaUno = (float)nota;
                                        ManejadorDeDatos.ActualizarEstadoMateria(nuevoEstado, idAlumno);
                                        MessageBox.Show("Nota puesta");
                                        txtNota.Text = null;
                                        break;

                                    case "Segundo parcial":
                                        nuevoEstado.NotaDos = (float)nota;
                                        nuevoEstado.IdParcialDos = idParcial;
                                        ManejadorDeDatos.ActualizarEstadoMateria(nuevoEstado, idAlumno);
                                        MessageBox.Show("Nota puesta");
                                        txtNota.Text = null;
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("falta ingresar que materia es");
                            }

                        }
                        else
                        {
                            MessageBox.Show("falta ingresar que materia es");
                        }
                    }
                    else
                    {
                        MessageBox.Show("falta ingresar que parcial es");
                    }
                }
                else
                {
                    MessageBox.Show("La nota tiene que ser entre 1 y 10");
                }
 
            }
            else
            {
                MessageBox.Show("falta ingresar la nota");
            }
        }

        /// <summary>
        /// Se fija cual de los 2 raddio button esta selecionado y se fija si el parcial es para la 1 nota o 2 nota
        /// </summary>
        /// <returns>devuelve un string que te dice que parcial es Primer parcial o Segundo parcial</returns>
        public string saberParcial()
        {
            string saber = "";
            if (rdbPrimerParcial.Checked == true)
            {
                saber = "Primer parcial";
            }
            else
            {
                saber = "Segundo parcial";

            }
            return saber;
        }

        
    }
}
