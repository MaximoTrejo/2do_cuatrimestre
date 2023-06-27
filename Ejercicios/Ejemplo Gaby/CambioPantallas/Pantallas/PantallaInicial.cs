using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CambioPantallas.Pantallas
{
    public partial class PantallaInicial : UserControl
    {
        Form1 formularioPadre;

        public PantallaInicial(Form1 formularioPadre)
        {
            InitializeComponent();
            this.formularioPadre = formularioPadre;
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            formularioPadre.cambiarPantalla("rojo");
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            formularioPadre.cambiarPantalla("azul");

        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            formularioPadre.cambiarPantalla("verde");

        }

        private void btnVioleta_Click(object sender, EventArgs e)
        {
            formularioPadre.cambiarPantalla("violeta");

        }

        private void btnNegro_Click(object sender, EventArgs e)
        {
            formularioPadre.cambiarPantalla("negra");
        }
    }
}
