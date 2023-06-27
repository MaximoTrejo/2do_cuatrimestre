using Jugador;

namespace Ejercicio_C01__Clase_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo.Equipo equipo = new Equipo.Equipo(2, "utn");
            Jugador.Jugador j1 = new Jugador.Jugador(123, "nom1", 5, 20);
            Jugador.Jugador j2 = new Jugador.Jugador(485, "nom2", 3, 5);
            Jugador.Jugador j3 = new Jugador.Jugador(123, "nom3", 7, 3);
            Jugador.Jugador j4 = new Jugador.Jugador(789, "nom4", 3, 5);

            if (equipo + j1)
                Console.WriteLine(j1.MostrarDatos());

            if (equipo + j2)
                Console.WriteLine(j2.MostrarDatos());

            if (equipo + j3)
                Console.WriteLine(j3.MostrarDatos());
            else
                Console.WriteLine("NO SE AGREGO " + j3.MostrarDatos());

            if (equipo + j4)
                Console.WriteLine(j4.MostrarDatos());

            else
                Console.WriteLine("NO SE AGREGO " + j4.MostrarDatos());

            if (j1 != j2)
                Console.WriteLine("son dif");
        }
    }
}
