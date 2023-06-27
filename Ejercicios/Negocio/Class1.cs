using PuestoAtencion;
using Cliente;
namespace Negocio
{
    public class Negocio
    {
        PuestoAtencion.PuestoAtencion caja;
        string nombre;
        Queue<Cliente.Cliente> Clientes;

        private Negocio()
        {

            Clientes = new Queue<Cliente.Cliente>();
            caja = new PuestoAtencion.PuestoAtencion(Puesto.Caja1);

        }
        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }


        //porque quiero devlver un cliente
        public Cliente.Cliente Cliente
        {

            set
            {



                //_=this+value; //preguntar profe





                //contains si contiene ese valor 
                if (!(Clientes.Contains(value)))
                {
                    Clientes.Enqueue(value);
                }
            }

            get
            {
                //Dequeue te devuelve el proximo de la fila 
                return Clientes.Dequeue();

            }
        }


        //las propiedades solo tienen get y set 
      public int ClientesPendientes
      {
           get
           {
                //en este caso solo quiero devlver el numero que datos que ese enceunyrab en la lista 
                //para esto uso el count que t devuelv el numro contenido en la lista
                return Clientes.Count;
           }
      }




        //el orador + solo agrega a mi lista de clientes si el cliente es igual y sigue buscando hasta que no lo encuentre 
        public static bool operator +(Cliente.Cliente c , Negocio n)
        {
            bool noesta = true;
            //count te devuelve la cantidad de elementos de la lista 
            //si es 0 lo agrego sin recorrer la lista
            if (n.Clientes.Count > 0)
            {
                //devuelvo cliente porque mi lista es de clientes , del tipo clientes 
                foreach (Cliente.Cliente i in n.Clientes)//no se agrega y no se quita ,, modificar si 
                {
                   
                    //con el forech recorro el clientes me da un cliente y lo comparo con el if contra otro cliente de mi clase clientes con el operador ==
                    if (i != c)
                    {
                        noesta = true;
                    }
                    else
                    {
                       
                        noesta = false;
                        break;//salgo y sigo
                    }

                }
            }
            if(noesta){

                n.Clientes.Enqueue(c);
            }

            return false;
        }




        public static bool operator ==(Negocio n1 , Cliente.Cliente c1)
        {
            bool respuesta =false;

            if (n1.Clientes.Count > 0) {

                foreach (Cliente.Cliente i in n1.Clientes)
                {
                    if (c1 == i)
                    {
                        respuesta = true;
                        break;//porque eso me pide el ejercciio 
                    }
                }
            } 
            return respuesta;
        }

        public static bool operator !=(Negocio l1, Cliente.Cliente c1)
        {

            return !(l1 == c1);
        }


        /*
         * Es importante tener en cuenta que el operador "~" solo se puede aplicar a tipos numéricos enteros, como int, long, short, etc. y no se puede aplicar a tipos de punto flotante, como float o double
         */
    }
}