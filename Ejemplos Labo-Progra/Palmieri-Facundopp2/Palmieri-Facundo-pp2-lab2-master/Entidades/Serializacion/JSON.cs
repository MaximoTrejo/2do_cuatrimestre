using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Entidades.Interface;
namespace Entidades.Serializacion
{
    public class JSON<T> : IArchivo<T> where T : class
    {
        private IArchivo<T>.ETipoArchivo eTipoArchivo;

        public JSON(IArchivo<T>.ETipoArchivo eTipoArchivo)
        {
            this.eTipoArchivo = eTipoArchivo;
        }

        public string Escribir(T dato, string path)
        {
            string pathFinal = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            pathFinal += "\\";
            pathFinal += path;
            try
            {
                    pathFinal += ".json";

                    if (Path.GetExtension(pathFinal) == ".json")
                    {
                        Archivo archivo = new Archivo();
                        archivo.Escribir(JsonSerializer.Serialize(dato, typeof(T)), pathFinal);
                    }
                    else
                    {
                        throw new Exception("Extensión no válida: no es una extensión .json");
                    }
                
            }
            catch (Exception e)
            {
                throw new Exception($"{e.Message}");
            }

         return pathFinal;

            
        }


    }
}
