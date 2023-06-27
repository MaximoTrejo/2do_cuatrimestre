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

namespace Ejercicio_I01___La_lista_del_super
{
    public partial class FrmVistaSuper : Form
    {
        private static string rutaArchivo;
        private List<string> listaSupermercado;

        static FrmVistaSuper()
        {
            string applicationData = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nombreArchivo = "listaSuper.xml";
            rutaArchivo = Path.Combine(applicationData, nombreArchivo);
        }

        public FrmVistaSuper()
        {
            InitializeComponent();
            listaSupermercado = new List<string>();
        }



        private void FrmVistaSuper_Load(object sender, EventArgs e)
        {

            toolTip.SetToolTip(btnAgregar, "Agregar objeto");
            toolTip.SetToolTip(btnEliminar, "Eliminar objeto");
            toolTip.SetToolTip(btnModificar, "Modificar objeto");

            listaSupermercado = new List<string>();

            if (File.Exists(rutaArchivo))
            {
                RecuperarDatos();
                actualizarListBox();
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Agregar objeto", string.Empty, "Agregar");
            frmAltaModificacion.ShowDialog();//para que no se pueda usar el resto de la aplicaccion

            if (frmAltaModificacion.DialogResult == DialogResult.OK)
            {
                string nuevoObjeto = frmAltaModificacion.objeto;
                //busca el indice del objeto selecionado
                if (listaSupermercado.Contains(nuevoObjeto))
                {
                    MessageBox.Show("El objeto ya estaba cargado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    listaSupermercado.Add(nuevoObjeto);
                    GuardarDatos();
                    actualizarListBox();
                }


            }
        }

        private void actualizarListBox()
        {
            lstOjetos.DataSource = null;
            lstOjetos.DataSource = listaSupermercado;
        }

        private void GuardarDatos()
        {
            using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());
                xmlSerializer.Serialize(streamWriter, listaSupermercado);
            }
        }
        private void RecuperarDatos()
        {
            using (StreamReader streamReader = new StreamReader(rutaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());
                listaSupermercado = xmlSerializer.Deserialize(streamReader) as List<string>;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string objetoSeleccionado = obtenerObjetoSeleccionado();
            if (objetoSeleccionado is not null)
            {
                listaSupermercado.Remove(objetoSeleccionado);
                actualizarListBox();
                GuardarDatos();
            }
        }

        private string obtenerObjetoSeleccionado()
        {
            string objetoSeleccionado = lstOjetos.SelectedItem as string;

            if (objetoSeleccionado is null)
            {
                MessageBox.Show("Debe seleccionar un objeto  de la lista", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return objetoSeleccionado;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string objetoSeleccionado = obtenerObjetoSeleccionado();


            if (objetoSeleccionado is not null)
            {
                FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Modificar objeto", objetoSeleccionado, "Modificar");
                frmAltaModificacion.ShowDialog();//para que no se pueda usar el resto de la aplicaccion

                if (frmAltaModificacion.DialogResult == DialogResult.OK)
                {
                    string objetoModificado = frmAltaModificacion.objeto;

                    int indiceOjetoSelecionado = listaSupermercado.IndexOf(objetoSeleccionado);

                    listaSupermercado[indiceOjetoSelecionado] = objetoModificado;

                    GuardarDatos();
                    actualizarListBox();


                }
            }


        }
    }
}
