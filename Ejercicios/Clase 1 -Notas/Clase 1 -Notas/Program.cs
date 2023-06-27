namespace Clase_1__Notas
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //tipos de valiables
            int numero = 4;
            string cadena = "Hello, World!";
            //float flotante = 10;
            bool flag  = false;

            //el if si quiero que sea verdadero directamente pongo la valiable sin aclarar
            if(flag)
            {
                Console.WriteLine("Si");
            }
            else
            {
                Console.WriteLine("No");
            }

            //formas de mostrar por consola 
            Console.WriteLine(cadena);
            Console.WriteLine("Mi numero es " + numero);
            Console.WriteLine($"Mi numero es {numero}");
        }

        //funciones = metodos
        internal int Contar()
        {
            return 2;
        }

    }
}