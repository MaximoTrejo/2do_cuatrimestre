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
    public partial class PantallaRoja : UserControl
    {

        Form1 formularioPadre;

        public PantallaRoja(Form1 formularioPadre)
        {
            InitializeComponent();

            this.formularioPadre = formularioPadre;
        }
    }
}
