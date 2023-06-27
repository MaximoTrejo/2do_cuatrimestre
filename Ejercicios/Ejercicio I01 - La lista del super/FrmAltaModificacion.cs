namespace Ejercicio_I01___La_lista_del_super
{
    public partial class FrmAltaModificacion : Form
    {
        public FrmAltaModificacion(string titulo, string textoTextBox, string textoBotonConfirmar)
        {
            InitializeComponent();
            Text = textoTextBox;
            txtObjeto.Text = textoTextBox;
            btnConfirmar.Text = textoBotonConfirmar;
        }

        public string objeto
        {
            get
            {
                return txtObjeto.Text;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            confirmar();
        }

        private void confirmar()
        {
            if (string.IsNullOrWhiteSpace(txtObjeto.Text))
            {
                MessageBox.Show("Debe ingresar un texto", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void cancelar()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que al precionar no sea enter
            if (e.KeyChar == (char)13)
            {
                confirmar();
            }
            else if (e.KeyChar == (char)27)
            {
                cancelar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }
    }
}