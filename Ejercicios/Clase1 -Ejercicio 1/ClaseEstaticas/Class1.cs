namespace ClaseEstaticas
{
    public class Class1
    {

        public static bool validarPrimos(int numeroPrimo)
        {
            bool bandera = false;

            //si numero primo es menor que 2 no pasa
            if (numeroPrimo < 2)
            {
                bandera = false;
            }
            else
            {
                //hago un bucle que empieza desde el 2 porque el 0 y el 1 no son primos 
                //sigo iterando hasta que llegue al numero que ingreso al usuario
                for (int i = 2; i <= numeroPrimo; i++)
                {
                    //en cada iteraccion valido que el numero dividido no tenga resto
                    //"%" Este operador calcula el resto de la división de un número por otro.
                    //Por ejemplo, si a = 7 y b = 3, entonces el resultado de a % b sería 1, porque 7 dividido por 3 es 2 con un resto de 1.
                    if (numeroPrimo % i == 0)
                    {
                        //cambio la bandera 
                        bandera = true;
                    }
                }
                
            }
            return bandera;
        }

        public static void mostrarPrimos(int numeroPrimo)
        {
            //muestro el numero primo que quiero mostrarle los primos 
            Console.WriteLine($"Los numeros primos de  - {numeroPrimo} - ");

            //hago un for desde el 2 porque el 0 y 1 no son primos 
            for (int i = 2; i <= numeroPrimo; i++)
            {
                //si el numero que devuelve no es un primo no entra y por lo tanto no lo muestra 
                if (validarPrimos(i))
                {
                    Console.Write(i + " - ");
                }
            }
        }
    }
}