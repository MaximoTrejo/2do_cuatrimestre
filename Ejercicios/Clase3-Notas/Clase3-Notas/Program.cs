//objeto == con lo que contruyo el objeto , puede ser muchos y te devuelve un estado 
//como una espada tiene varios materiales pero la espada es la misma 

//new crea espacio en memoria

//constructor se llama igual que la clase y sirve para asiganr valores a las variables

//this.nombre //con el this hago referencia a la variable de afuera no a la variable del metodo

namespace Clase3_Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constructor , esto se utiliza para llamar a los metodos publicos
            //lo que hace es new es reservar un espacio en memoria para ese constructor 
            Mascota perro = new Mascota();
            Mascota perro2 = new Mascota();


            Console.WriteLine(perro.saludar(perro2));
        }
    }
}