using System.ComponentModel.DataAnnotations;

namespace Clase1__Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numeros;
            int max=0;
            int min=0;
            int acumulador = 0;
            int promedio = 0;

            for (int i=0;i<5;i++)
            {
                Console.WriteLine("ingrese un numero");
                numeros=int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    max = numeros;
                    min = numeros;
                }
                else
                {
                    if (numeros > max)
                    {
                        max =  numeros;
                    }
                    else
                    {
                        if (numeros<min)
                        {
                            min = numeros;
                        }
                    }
                }
                acumulador++;
            }

            promedio=acumulador/5;
            Console.WriteLine($"maximo {max}");
            Console.WriteLine($"minimo {min}");
            Console.WriteLine($"promerio {promedio}");
        }
    }
}