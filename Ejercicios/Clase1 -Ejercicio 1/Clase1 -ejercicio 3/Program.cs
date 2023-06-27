/*
 * 
 * Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

Validar que el dato ingresado por el usuario sea un número.

Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

Si ingresa "salir", cerrar la consola.

Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
*/

using Microsoft.VisualBasic.FileIO;
using System;
using ClaseEstaticas;

namespace Clase1__ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string imput;
            bool bandera=false;
            int numeroPrimo;

            //objeto(solo publicas)
            Class1 class1 = new Class1();

            //si es estatico no es necesario hacer un objeto
            //ClaseEstaticas.Class1.validarPrimos

            do
            {
                Console.WriteLine("\n1-Numero Primos");
                Console.WriteLine("2-Salir\n");


                Console.WriteLine("ingrese un numero");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("ingrese un numero primo");
                            imput = Console.ReadLine();

                            if (int.TryParse(imput, out numeroPrimo) || numeroPrimo > 2)
                            {

                                //numeroPrimo = int.Parse(Console.ReadLine());
                                ClaseEstaticas.Class1.mostrarPrimos(numeroPrimo);

                            }
                            else
                            {
                                Console.WriteLine("Ingrese un numero valido");
                            }

                        } while (bandera == true);

                        break;
                    case 2:
                        break;

                }

            } while (opcion != 2);
            


            

        }


        
        
    }
}