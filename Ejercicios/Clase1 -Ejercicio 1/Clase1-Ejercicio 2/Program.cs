namespace Clase1_Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeros;
            bool bandera=false;
            double cuadrado;
            double cubo;

            //el bucle empiezo con la bandera el false y se sigue dentro del bucle hasta que sea diferente 
            do
            {
                Console.WriteLine("ingrese un numero");
                numeros = int.Parse(Console.ReadLine());

                //si el numero es menor a 0 muestra errror sino es 0 cambia la bandera 
                if (numeros<0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    bandera = true;
                }

            }while(bandera == false);

            cuadrado = Math.Pow(numeros,2);
            Console.WriteLine($"el cuadrado es {cuadrado}");

            cubo = Math.Pow(numeros, 3);
            Console.WriteLine($"el cuadrado es {cubo}");

        }
    }
}