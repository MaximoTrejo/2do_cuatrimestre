/*
 *Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.

Mostrar el vector tal como fue ingresado.
Luego mostrar los positivos ordenados en forma decreciente.
Por último, mostrar los negativos ordenados en forma creciente. 
 * 
*/

using System.Collections.Generic;

namespace Ejercicio_I01__Clase_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];

            Random randomNum = new Random();

            for (int i=0;i< 20; i++)
            {

                numeros[i] = randomNum.Next(-100, 100);

                while (numeros[i] == 0)
                {
                    numeros[i] = randomNum.Next(-100, 100);
                }
            }
            Console.WriteLine("//---------------------Listar Random------------------------");

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\n//---------------------Listar positivos-------------------------");


            int[] positivos = new int[20];
            int[] negativos = new int[20];
            List<int> listPositivos = new List<int>();
            List<int> listNegativos = new List<int>();

            for (int j = 0; j < 20; j++)
            {
                if (numeros[j] >= 0)
                {
                    positivos[j] = numeros[j];
                    listPositivos.Add(positivos[j]);
                }
                else
                {
                    negativos[j] = numeros[j];
                    listNegativos.Add(negativos[j]);
                }
            }

            listPositivos.Sort();
            foreach (int j in listPositivos)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("\n\n//---------------------Listar Negativos-------------------------");

            listNegativos.Sort();
            foreach (int j in listNegativos)
            {
                Console.WriteLine(j);
            }
            

        }
    }
}