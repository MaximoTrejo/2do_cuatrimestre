using Colores;
namespace Moto
{
    public class Moto
    {
        short cantidadRuedas;
        short cantidadPuertas;
        int pesoCarga;
        short cilindrada;
        Colores.Colores color ;

        public Moto(short cantidadRuedas,short cantidadPuertas, int pesoCarga, short cilindrada ,Colores.Colores color)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadRuedas = cantidadRuedas;
            this.pesoCarga = pesoCarga;
            this.cilindrada = cilindrada;
            this.color = color;
        }
    }
}