using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_Notas
{
    internal class Mascota
    {
        int edad;
        string nombre;
        //static int total; una variable estaticos se comparte con todos , por ejemplo si tengo un total de cartas y todos agarran , se resta de ese total
        public Mascota() 
        {
            this.edad = 0;
            this.nombre = "hola";

        }
        public string GetNombre()
        {
            return nombre;
        }

        //public string saludar()
        public string saludar(Mascota a1)
        {
            return this.GetNombre();
        }
    }
}
