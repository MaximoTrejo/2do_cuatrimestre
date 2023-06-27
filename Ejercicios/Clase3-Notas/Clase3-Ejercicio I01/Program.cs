namespace Clase3_Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cuenta cuenta = new cuenta("Natalia", 400);
            Console.WriteLine(cuenta.mostrar());

            Console.WriteLine("-------------------------------");
            cuenta.ingresar(200);
            Console.WriteLine(cuenta.mostrar());

            Console.WriteLine("-------------------------------");
            cuenta.retirar(200);
            Console.WriteLine(cuenta.mostrar());
        }
    }
}