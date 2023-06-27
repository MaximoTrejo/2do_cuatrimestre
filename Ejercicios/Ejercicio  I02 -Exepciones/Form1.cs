

namespace Ejercicio__I02__Exepciones
{
    public partial class Calculador : Form
    {
        public Calculador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txbKilometros.Text == "" || this.txbLitros.Text == "")
                {
                    throw new ParametrosVaciosException("algunos de los campos esta vacio");
                }

                this.rTBoxCalcular.Text = $"km / hs :  { calculador.Calcular(int.Parse(this.txbKilometros.Text), int.Parse(this.txbLitros.Text))}";
            }
            catch(ParametrosVaciosException ex)//exepcion creada por nosotros
            {
                MessageBox.Show(ex.Message);
            }
            catch(FormatException ex)//exepcion error del formato
            {
                MessageBox.Show("El formato de entrada no es el correcto ");
            }
            catch (DivideByZeroException ex)//error de divicion por 0
            {
                MessageBox.Show("nose puede dividir por 0 ");
            }
            catch (Exception ex)//exepcion generica
            {
                MessageBox.Show("Exepcion generica");
            }
        }


       

    }
}