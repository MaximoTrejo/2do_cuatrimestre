namespace Conversor
{
    public class Class1
    {
        public static string DecimalaBinario(int numeroDecimal)
        {
            string binario = "";

            do
            {
                 
                binario = (numeroDecimal % 2).ToString() + binario;
                numeroDecimal /= 2;


            }while (numeroDecimal != 0);

            return binario;
        }

        public static int BinarioaDecimal(string numeroEntero)
        {
            double numeroDecimal = 0;
            int indiceInicial = numeroEntero.Length - 1;


            for (int i = numeroEntero.Length-1 ; i >= 0; i--)
            {
                if (numeroEntero[i] == '1')
                {
                    numeroDecimal += Math.Pow(2, indiceInicial - i );
                }
            }
            return (int)numeroDecimal;
        }
    }
}