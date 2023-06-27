using Validador;

namespace Ejercicio_I02__Clase_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string? imput;
            char respuesta;
            int numero;
            int acumulador = 0;

            do
            {
                Console.WriteLine("\ningrese un numero");
                imput = Console.ReadLine();

                if (int.TryParse(imput, out numero))
                {
                    acumulador += numero;
                    Console.WriteLine($"suma {acumulador}");
                }

                Console.WriteLine("¿Desea continuar? (S/N)");
                respuesta = Console.ReadKey().KeyChar;

            } while (Validador.Class1.ValidarRespuesta(respuesta));
                       
        }
    }
}