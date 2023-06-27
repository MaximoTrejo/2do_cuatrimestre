using Conversor;

namespace Ejercicio_I03___Clase_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Conversor.Class1.DecimalaBinario(10)}");

            Console.WriteLine($"{Conversor.Class1.BinarioaDecimal("1010")}");
        }
    }
}