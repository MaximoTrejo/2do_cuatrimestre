using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interface
{
    public interface IArchivo<T> where T : class
    {
        public enum ETipoArchivo { CSV, JSON };


        /// <summary>
        /// Si el archivo existe, le escribe los datos. De no existir, lo crea.
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="path"></param>
        string Escribir(T dato, string path);
    }
}
