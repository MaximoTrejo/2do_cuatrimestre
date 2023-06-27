namespace Automobile
{
    public class Automobile
    {
        short cantidadRuedas;
        short cantidadPuertas;
        short cantidadMarchas;
        int cantidadPasajeros;

        public Automobile(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, int cantidadPasajeros)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPasajeros = cantidadPasajeros;
            this.cantidadMarchas = cantidadMarchas;
        }
    }
}