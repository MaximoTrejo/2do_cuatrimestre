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
namespace IU
{
    public partial class frmLogin : Form
    {
        bool flagMostrarContraseña;
        public frmLogin()
        {
            InitializeComponent();
        }


        
        /// <summary>
        /// cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// minimizar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region moverElForm


        public int m;
        public int mx;
        public int my;
        /// <summary>
        /// funcion para saber donde estas agarrando del panel 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlBordeSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        /// <summary>
        /// Funcion para calcular donde mover el panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlBordeSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        /// <summary>
        /// Funcion para detectar que dejo de agarrrar el panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlBordeSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
        #endregion

        /// <summary>
        /// Auto completador para ingresar como alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlumno_Click(object sender, EventArgs e)
        {
            txtContra.Text = "F4cu";
            txtDni.Text = "43803788";
        }

        /// <summary>
        /// auto completador para ingresar como profesor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProfesor_Click(object sender, EventArgs e)
        {
            txtContra.Text = "Lo.Da";
            txtDni.Text = "32543782";
        }

        /// <summary>
        /// Auto completador para ingresar como admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            txtContra.Text = "H33B";
            txtDni.Text = "32412341";
        }

        /// <summary>
        /// Funcion para que solo pueda ingresar numeros en el txtDni 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Funcion para ingresar como alumno, profesor o administrador si todos los campos son correctos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string contraAux;
            string auxTipoPersona;
            int dniAux;
            if (txtDni.Text is not null && int.TryParse(txtDni.Text, out dniAux))
            {
                if (txtContra.Text is not null && txtContra.Text != "")
                {
                    contraAux = txtContra.Text;
                    Persona miPersona = ManejadorDeDatos.checkLogin(dniAux, contraAux);


                    if (miPersona is not null)
                    {
                        auxTipoPersona = ManejadorDeDatos.checkTipoPersona(miPersona);
                        switch (auxTipoPersona)
                        {
                            case "Alumno":
                                frmAlumno frmAlumno = new frmAlumno(miPersona);
                                frmAlumno.Show();
                                this.Hide();

                                break;
                            case "Profesor":
                                frmProfesores frmProfes = new frmProfesores(miPersona);
                                frmProfes.Show();
                                this.Hide();
                                break;

                            case "Admin":
                                fmrAdmin fmrAdmi = new fmrAdmin(miPersona);
                                fmrAdmi.Show();
                                this.Hide();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña o DNI es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Falta completar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Falta completar el DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /// <summary>
        /// Funcion para poner visible las letras de la contraseña o dejarla la contraseña oculta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbMostrarContra_Click(object sender, EventArgs e)
        {
            if(flagMostrarContraseña == true)
            {
                flagMostrarContraseña = false;
                txtContra.UseSystemPasswordChar = true;
            }
            else
            {
                txtContra.UseSystemPasswordChar = false;
                flagMostrarContraseña = true;
            }
        }
    }
}
