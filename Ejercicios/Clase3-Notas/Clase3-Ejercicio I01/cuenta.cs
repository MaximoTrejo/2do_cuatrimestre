using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_Ejercicio_I01
{

    //get preguntar
    //set guardar
    internal class cuenta
    {
        public int cantidad = 0;
        public string titular;

        public cuenta(string titular , int cantidad)
        {
            this.cantidad = cantidad;
            this.titular= titular;

        }

        public string mostrar()
        {
            string retorno = $"el titular es {titular} y la cantidad es {cantidad}";
           
            return retorno;
        }

        //exponer fuera un valor 
        public int GetCantidad()
        {
            return this.cantidad;
        }

        //exponer fuera un valor
        public string GetTitular()
        {
            return this.titular;
        }

        public void ingresar(int monto)
        {
            if (monto > 0)
            {
                cantidad = cantidad+monto;

            }
            else
            {
                Console.WriteLine("mal");
            }


        }

        public void retirar(int monto)
        {
            if (cantidad < 0)
            {
                Console.WriteLine("mal");
            }
            else
            {
               cantidad -= monto;
            }
              
        }

    }
}
