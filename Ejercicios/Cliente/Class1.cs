namespace Cliente
{
    public class Cliente
    {
        string nombre;
        int numero;

       
        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(int numero, string nombre): this(numero)
        {
            this.nombre=nombre;
        }

        public string Nombre { get; set; }

        public int Numero
        {
            get
            {
                return Numero;
            }
        }




        /*
         * 
         * EJEMPLO
        public static bool operator ==(int i , Cliente c1)
        {
            return (i == c1.Numero);
        }

        public static bool operator !=(int i, Cliente c1)
        {
            return (i != c1.Numero);
        }

        */

        public static bool operator == (Cliente c1, Cliente c2)
        {
            bool respuesta;
            if (c1.numero == c2.numero )
            {
                respuesta=true;
            }
            else
            {
                respuesta= false;
            }

            return respuesta;
            //return (c1.numero == c2.numero); forma corta 
        }
        public static bool operator != (Cliente c1, Cliente c2)
        {
            return !(c1.numero == c2.numero);
        }
 
    }
}