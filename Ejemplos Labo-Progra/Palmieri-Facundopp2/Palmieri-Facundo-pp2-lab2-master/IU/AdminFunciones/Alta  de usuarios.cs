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
    public partial class fmrAltaDeUsuarios : Form
    {
        Persona miPersona;
        public fmrAltaDeUsuarios()
        {
            InitializeComponent();
        }
        public fmrAltaDeUsuarios(Persona miPersona): this()
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
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void ptbAtras_Click(object sender, EventArgs e)
        {
            fmrAdmin frmadmin = new fmrAdmin(miPersona);
            frmadmin.Show();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cancelar la creacion del usuario, se borraran todos los campos", "Alerta", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MessageBox.Show("cancelacion confirmada");
                LimpiarTodosLosCampos();
            }

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            string auxNombre = "hola";
            string auxApellido = "apellid";
            string auxContra ="asd";
            int auxDni = -1;
            string auxTipoUsuario="no tiene";




            if (rdbAdmin.Checked == true)
            {
                auxTipoUsuario = "admin";
            }
            else if (rdbAlumno.Checked == true)
            {
                auxTipoUsuario = "alumno";
            }
            else if (rdbProfesor.Checked == true)
            {
                auxTipoUsuario = "profesor";
            }
            else
            {
                MessageBox.Show("Falta completar que tipo de usuario es");
            }



            if (txtNombre.Text is not null && txtNombre.Text != "")
                {
                    if (txtApellido.Text is not null && txtApellido.Text != "")
                    {
                        if (txtDni.Text is not null && txtDni.Text != "" && int.TryParse(txtDni.Text, out auxDni))
                        {                      
                            if (ManejadorDeDatos.dniUnico(auxDni))
                            {
                                if (txtContra.Text is not null && txtContra.Text != "")
                                {
                                    auxApellido = txtApellido.Text;
                                    auxNombre = txtNombre.Text;
                                    auxContra= txtContra.Text;

                                }
                                else
                                {
                                    MessageBox.Show("Falta completar que tipo la contraseña");
                                }
                            }
                            else
                            {
                                MessageBox.Show("DNI YA EXISTE");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Falta completar el dni");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falta completar el tipo apellido");
                    }
            }
            else
            {
              MessageBox.Show("Falta completar el nombre");
            }

            switch (auxTipoUsuario)
            {
                case "admin":
                    Admin auxAdmin = new Admin(auxNombre, auxApellido, auxDni, auxContra);

                    if (MessageBox.Show(auxAdmin.MostrarDatos(), "¿Desea crear este administrador?", MessageBoxButtons.YesNo)== DialogResult.Yes)
                    {
                        MessageBox.Show("creado");
                        ManejadorDeDatos.CargarPersonaEnLista(auxAdmin);
                        PersonaDAB.AddPersona(auxDni, auxApellido, auxNombre, auxContra, 3);
                        AdminDAB.AddAdmin(auxAdmin.IdAdmin, auxDni);
                        LimpiarTodosLosCampos();

                    }
                    else
                    {
                        MessageBox.Show("no creado");

                    }
                    break;
                case "alumno":

                    Alumno auxAlumno = new Alumno(auxNombre,auxApellido,auxDni,auxContra);

                    if (MessageBox.Show(auxAlumno.MostrarDatos(),"¿Desea crear este alumno?",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("creado");
                        ManejadorDeDatos.CargarPersonaEnLista(auxAlumno);
                        PersonaDAB.AddPersona(auxDni, auxApellido, auxNombre, auxContra, 1);
                        AlumnosDAB.AddAlumno(auxAlumno.Legajo, auxAlumno.CantMateriasDando, auxDni);



                        LimpiarTodosLosCampos();
                    }
                    else
                    {
                        MessageBox.Show("no creado");

                    }
                    break;
                case "profesor":
                    Profesor auxProfe=new Profesor(auxNombre,auxApellido,auxDni,auxContra);
                    if(MessageBox.Show(auxProfe.MostrarDatos(), "¿Desea crear este Profesor?", MessageBoxButtons.YesNo)== DialogResult.Yes)
                    {
                        MessageBox.Show("creado");
                        ManejadorDeDatos.CargarPersonaEnLista(auxProfe);
                        PersonaDAB.AddPersona(auxDni, auxApellido, auxNombre, auxContra, 2);
                        ProfesoresDAB.AddProfe(auxProfe.IdProf, auxDni);
                        LimpiarTodosLosCampos();
                    }
                    else
                    {
                        MessageBox.Show("no creado");

                    }
                    break;
            }
        }



        private void LimpiarTodosLosCampos()
        {
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtDni.Text = null;
            txtContra.Text = null;
            rdbAdmin.Checked = false;
            rdbAlumno.Checked = false;
            rdbProfesor.Checked = false;
        }


    }
}