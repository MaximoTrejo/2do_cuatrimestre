using CambioPantallas.Pantallas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CambioPantallas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void cambiarPantalla(String opcion)
        {
            panelPantalla.Controls.Clear();
            UserControl pantalla = null;
            switch (opcion)
            {
                case "inicio":
                    pantalla = new PantallaInicial(this);
                    break;
                case "rojo":
                    pantalla = new PantallaRoja(this);
                    break;
                case "azul":
                    pantalla = new PantallaAzul(this);
                    break;
                case "verde":
                    pantalla = new PantallaVerde(this);                   
                    break;
                case "negra":
                    pantalla = new PantallaNegra(this);
                    break;
            }
            panelPantalla.Controls.Add(pantalla);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cambiarPantalla("inicio");
        }
    }
}
