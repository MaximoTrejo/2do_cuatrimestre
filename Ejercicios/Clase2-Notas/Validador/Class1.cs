namespace Validador
{
    public class Class1
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool bandera = false;
            if (valor <= 100 && valor >= -100 )
            {
               bandera = true;
            }
            else
            {
                Console.WriteLine("ingrese un valor entre 100 y -100");
            }

            return bandera;
        }


        public static bool ValidarRespuesta(char respuesta)
        {
            bool bandera = false;

            if (respuesta == 'S' || respuesta == 's')
            {

                 bandera = true; 
            }
            else
            {
                //Console.WriteLine("¿Desea continuar? (S/N)");
                bandera = false;
            }

            return bandera;
        }

    }
}

