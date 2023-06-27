namespace Ejercicio_I03__Colecciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            string Texto;
            string[] subcadenas;

            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<string> listPalabras = new List<string>();

            Texto = this.richTextBox1.Text;

            

            foreach (char i in Texto)
            {
                if (dict.ContainsKey(Texto))
                {
                    
                    dict[Texto]++;
                }
                else
                {
                    dict.Add(Texto, i);
                    dict[Texto] = 1;
                }
                listPalabras.Add(Texto);    
            }
            listPalabras.Sort();

            foreach (string i in listPalabras)
            {
                MessageBox.Show(i);
            }
        }
    }
}