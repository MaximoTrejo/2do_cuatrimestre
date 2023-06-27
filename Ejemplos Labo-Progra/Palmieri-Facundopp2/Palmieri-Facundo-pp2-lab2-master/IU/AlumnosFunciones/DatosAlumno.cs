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
    public partial class fmrDatosAlumno : Form
    {
        Alumno miPersona;

        public fmrDatosAlumno()
        {
            InitializeComponent();
        }
        public fmrDatosAlumno(Persona miPersona) : this()
        {
            this.miPersona = (Alumno)miPersona;
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

        private void fmrDatosAlumno_Load(object sender, EventArgs e)
        {
            cargaDatosAlumno();
            cargaRtbConEstadoDelasMaterias();
        }

        private void cargaDatosAlumno()
        {
            lblApellido.Text += miPersona.Apellido;
            lblNombre.Text += miPersona.Nombre;
            lblDni.Text += miPersona.Dni;
            lblLejago.Text += miPersona.Legajo;
        }

        private void cargaRtbConEstadoDelasMaterias()
        {
            string nombreMateria;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("materia   -   1er parcial   -   2do parcial   -   promedio   -   presente   -   estado de la materia");
            foreach (EstadoMateria item in miPersona.Materias)
            {
                nombreMateria= ManejadorDeDatos.obtenerMateriaPorId(item.IdMateria);

                if (nombreMateria != "a")
                {
                    sb.Append(nombreMateria);
                }
                if(item.NotaUno != -1)
                {
                    sb.Append($" - {item.NotaUno}");
                }
                else
                {
                    sb.Append($" - no tuvo parcial");
                }
                if (item.NotaDos != -1)
                {
                    sb.Append($" - {item.NotaDos}");
                }
                else
                {
                    sb.Append($" - no tuvo 2do parcial");
                }
                if (item.NotaUno != -1 && item.NotaDos != -1)
                {
                    sb.Append($" - { (item.NotaUno + item.NotaDos) / 2 }");
                }
                else
                {
                    sb.Append($" - Le falta dar 1 o 2 parciales");
                }
                if(item.Presente == true)
                {
                    sb.Append($" - Presente");
                }
                else
                {
                    sb.Append($" - No presente");
                }

                switch (item.Estado_Materia)
                {
                    case eEstado.Regular:
                        sb.AppendLine($" - Regular");
                        break;
                    case eEstado.Libre:
                        sb.AppendLine($" - Libre");
                        break;
                    case eEstado.Cursando:
                        sb.AppendLine($" - Cursando");
                        break;
                    case eEstado.aprobado:
                        sb.AppendLine($" - Aprobado");
                        break;

                }


            }
            rtbDatosMateria.Text = sb.ToString();


        }



    }
}
