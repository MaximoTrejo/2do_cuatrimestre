using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4
{
    internal class Class1
    {

        int edad;
        string nombre;
        //sobrecarga de contructores--- se puede reutilizar el codigo utilizando el this()-(poner el parametro del construnctor que necesitas) 
        public Class1 (){

            this.edad = 0;
            this.nombre = "hola";
        }

        public Class1(int clase1, string clase2): this()
        {
            this.nombre = clase2;
        }


        //la sobrecarga permite agregar mas parametros a la funcion sin la necesidad de cambiar el nombre 

        public int saludar(int perro1)
        {

        }

        public int saludar(int perro1 , string perro2)
        {

        }

        
    }



}
