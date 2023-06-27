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
    public partial class PantallaNaranja : UserControl
    {

        Form1 formularioPadre;

        public PantallaNaranja(Form1 formularioPadre)
        {
           
            InitializeComponent();

            this.formularioPadre = formularioPadre;
        }
    }
}
