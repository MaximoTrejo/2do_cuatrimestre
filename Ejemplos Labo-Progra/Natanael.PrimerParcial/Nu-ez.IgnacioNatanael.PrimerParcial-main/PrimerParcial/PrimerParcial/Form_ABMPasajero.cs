using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using Entidades;
using SerializarDeserializar;

namespace PrimerParcial
{
    public partial class Form_ABMPasajero: Form
    {
        List<Pasajero> pasajerosList = new List<Pasajero>();

        public Form_ABMPasajero()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxNombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pasajerosList.Add(new Pasajero("No", "existe", 0, "000", "000", "usuario", 500, 25, 5, 55, "Telefono"));


            //using (XmlTextWriter writer = new XmlTextWriter("C:\\archivos\\DatosLista.xml", Encoding.UTF8))
            //{
             //   XmlSerializer ser = new XmlSerializer((typeof(List<Pasajero>)));
             //   ser.Serialize(writer, pasajerosList);
           // }

              ManagerFileXMLPasajeros.Serializar(@"\datos\PASAJEROS_DATA.xml", pasajerosList);
        }
    }
}
