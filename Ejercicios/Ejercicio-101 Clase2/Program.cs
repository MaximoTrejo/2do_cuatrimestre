using Validador;

namespace Ejercicio_101_Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imput;
            int valor;
            int max =0;
            int min =0;

            for (int i=0;i<10;i++)
            {
                Console.WriteLine("ingrese un numero");
                imput = Console.ReadLine();

                if (int.TryParse(imput, out valor) && Validador.Class1.Validar(valor, max, min))
                {
                    if (i == 0)
                    {
                        max = valor;
                        min = valor;
                    }
                    else
                    {
                        if (valor > max)
                        {
                            max = valor;
                        }
                        else
                        {
                            if (valor < min)
                            {
                                min = valor;
                            }
                        }
                    }
                }
               
            }
           
            Console.WriteLine($"el maximo es {max} y el minimo es {min}");

        }
    }
}