using System.Runtime.CompilerServices;
using Cliente;
using System.Threading;

namespace PuestoAtencion
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private  Puesto Puesto;

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

        public bool Atender(Cliente.Cliente cli)
        {
            Thread.Sleep(2000);
            return true;
        }
    }

    public enum Puesto
    {
        Caja1,
        Caja2
    }
}