using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades___Ejercicio_I01
{
    internal class PuestoAtencion
    {

        private static int numeroActual;
        private Puesto Puesto;

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            Puesto = puesto;
        }
        public static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }

        public bool Atender(Cliente cli)
        {
            bool retorno = false;
            if (cli is not null)
            {
                Thread.Sleep(2000);
                retorno =true;
            }
            return retorno;
        }
    }

    public enum Puesto
    {
        Caja1,
        Caja2
    }
}

