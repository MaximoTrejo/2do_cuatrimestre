using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades___Ejercicio_I01
{
    public class Negocio
    {

        
            PuestoAtencion caja;
            string nombre;
            Queue<Cliente> Clientes;

            private Negocio()
            {

                Clientes = new Queue<Cliente>();
                caja = new PuestoAtencion(Puesto.Caja1);

            }
            public Negocio(string nombre): this()
            {
                this.nombre = nombre;
            }


            //porque quiero devlver un cliente
            public Cliente Cliente
            {

                set
                {



                //_=this+value; //preguntar profe



                   _ = this + value;

                //contains si contiene ese valor 
                /*
                if (!(Clientes.Contains(value)))
                    {
                        Clientes.Enqueue(value);
                    }
                */
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
            public static bool operator +(Negocio n, Cliente c)
            {
                bool noesta = false;

                //int cant = n.Clientes.Count();
                //count te devuelve la cantidad de elementos de la lista 
                //si es 0 lo agrego sin recorrer la lista

                //if (cant > 0){
                //devuelvo cliente porque mi lista es de clientes , del tipo clientes 
                    

                    //con el forech recorro el clientes me da un cliente y lo comparo con el if contra otro cliente de mi clase clientes con el operador ==
                        if (n != c)
                        { 
                           n.Clientes.Enqueue(c);
                           noesta = true;
                        }
                //}
                return noesta ;
            }




            public static bool operator ==(Negocio n1, Cliente c1)
            {
                bool respuesta = false;

                //if (n1.Clientes.Count > 0)
                //{

                    foreach (Cliente i in n1.Clientes)
                    {
                        if (c1 == i)
                        {
                            respuesta = true;
                            break;//porque eso me pide el ejercciio 
                        }
                    }
                //}
                return respuesta;
            }

            public static bool operator !=(Negocio l1, Cliente c1)
            {

                return !(l1 == c1);
            }


            /*
             * Es importante tener en cuenta que el operador "~" solo se puede aplicar a tipos numéricos enteros, como int, long, short, etc. y no se puede aplicar a tipos de punto flotante, como float o double
             */
    }
}


