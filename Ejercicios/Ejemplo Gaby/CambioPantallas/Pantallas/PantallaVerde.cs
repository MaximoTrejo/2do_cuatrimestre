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
    public partial class PantallaVerde : UserControl
    {

        Form1 formularioPadre;

        public PantallaVerde(Form1 formularioPadre)
        {
            InitializeComponent();
            this.formularioPadre = formularioPadre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formularioPadre.cambiarPantalla("inicio");
            
        }
    }
}
