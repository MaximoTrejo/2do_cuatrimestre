using Persona;

namespace Ejercicio_I02__Clase_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personas persona1= new Personas(2002 ,"Maxi" , 44052786);


            Console.WriteLine(persona1.mostrar(persona1));
        }
    }
}