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
namespace IU.AdminFunciones
{
    public partial class fmrCambiarEstado : Form
    {
        Admin miPersona;

        public fmrCambiarEstado()
        {
            InitializeComponent();
        }

        public fmrCambiarEstado(Persona persona) : this()
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

        private void fmrCambiarEstado_Load(object sender, EventArgs e)
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

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idMateriaAux = -1;
            idMateriaAux = ManejadorDeDatos.obtenerIdMateria(cmbMateria.Text);
            List<string> listaAlumno = ManejadorDeDatos.obtenerAlumnosPorMateria(idMateriaAux);
            cmbAlumno.Items.Clear();
            foreach (string item in listaAlumno)
            {
                cmbAlumno.Items.Add(item);
            }
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            string saberEstadoNuevo;
            string auxNombreAlumno;
            string auxMateria;
            int legajoAlumno;
            int idMateria;
            float promedio;
            bool flag=false;
            EstadoMateria nuevoEstado;


            saberEstadoNuevo = saberEstado();

            if (saberEstadoNuevo != "a")
            {
                if (cmbMateria.Text is not null && cmbMateria.Text != "")
                {
                    auxMateria = cmbMateria.Text;
                    idMateria = ManejadorDeDatos.obtenerIdMateria(auxMateria);
                    if (cmbAlumno.Text is not null && cmbAlumno.Text != "")
                    {
                        auxNombreAlumno = cmbAlumno.Text;
                        legajoAlumno = ManejadorDeDatos.ObtenerLegajoPorNombre(auxNombreAlumno);
                        nuevoEstado = ManejadorDeDatos.obtenerEstadoMateria(idMateria, legajoAlumno);
                        promedio = (nuevoEstado.NotaDos + nuevoEstado.NotaUno) / (float)2;

                        switch (saberEstadoNuevo)
                        {
                            case "Regular":
                                if (promedio > 6 && nuevoEstado.Presente == true )
                                {
                                    nuevoEstado.Estado_Materia = eEstado.Regular;
                                    flag = true;
                                }
                                else
                                {
                                    MessageBox.Show("No se puede cambiar al estado regular", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                            case "Libre":
                                if (promedio > 6)
                                {
                                    nuevoEstado.Estado_Materia = eEstado.Libre;
                                    flag = true;
                                }
                                else
                                {
                                    MessageBox.Show("No se puede cambiar al estado Libre", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                            case "Aprobado":
                                if (promedio > 6 && nuevoEstado.Presente == true)
                                {
                                    nuevoEstado.Estado_Materia = eEstado.aprobado;
                                    flag = true;
                                }
                                else
                                {
                                    MessageBox.Show("No se puede cambiar al estado Aprobado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                        }

                        if (flag == true)
                        {
                            if (ManejadorDeDatos.ActualizarEstadoMateria(nuevoEstado, legajoAlumno) == true)
                            {
                                MessageBox.Show("Se cambio el estado correctamente", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo cambiar el estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Selecione al alumno");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione la materia");
                }
            }
            else
            {
                MessageBox.Show("Selecione a que estado quiere poner la materia del alumno");
            }
        }

        public string saberEstado()
        {
            string saber = "a";
            if (rdbLibre.Checked == true)
            {
                saber = "Libre";
            }
            else if(rdbRegular.Checked == true)
            {
                saber = "Regular";
            }else if (rdbAprobado.Checked == true)
            {
                saber = "Aprobado";
            }
            return saber;   
        }



    }
}
