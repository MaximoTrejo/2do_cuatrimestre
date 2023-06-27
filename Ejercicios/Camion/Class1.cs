namespace Camion
{
    public class Camion
    {
        short cantidadRuedas;
        short cantidadPuertas;
        short cantidadMarchas;
        int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas,int pesoCarga)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadRuedas = cantidadRuedas;
            this.pesoCarga = pesoCarga;
            this.cantidadMarchas = cantidadMarchas;
        }

    }
}