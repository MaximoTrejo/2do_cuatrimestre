/*
 * Crear una aplicación de consola que cargue en una Lista, Pila y Cola 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.

    Mostrar la colección tal como fue cargada.
    Luego mostrar los positivos ordenados en forma decreciente.
    Por último, mostrar los negativos ordenados en forma creciente.
 * 
 */

namespace Ejercicio_I02____Clase_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random randomNum = new Random();

            List<int> lista = new List<int>();
            Stack<int> pila = new Stack<int>();
            Queue<int> cola = new Queue<int>();

            List<int> listPositivos = new List<int>();
            List<int> listNegativos = new List<int>();

            for (int i = 0; i < 20; i++)
            {

                int numeros = randomNum.Next(-100, 100);

                lista.Add(numeros);
                pila.Push(numeros);
                cola.Enqueue(numeros);
            }
            Console.WriteLine("\n\n//---------------------Lista-------------------------");
            foreach (int j in lista)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("\n\n//---------------------Pila-------------------------");
            foreach (int j in pila)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("\n\n//---------------------Cola-------------------------");
            foreach (int j in cola)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("\n\n//---------------------ordenar Lista-------------------------");


            for (int j = 0; j < 20; j++)
            {
                if (lista[j] >= 0)
                {
                    listPositivos.Add(lista[j]);
                }
                else
                {
                    
                    listNegativos.Add(lista[j]);
                }
            }

            listPositivos.Sort();
            foreach (int j in listPositivos)
            {
                Console.WriteLine(j);
            }
            
        }
    }
}