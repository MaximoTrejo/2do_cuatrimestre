using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Interface;

namespace Entidades.Serializacion
{
    public class Csv 
    {

        public string guardar(List<Alumno> dato, string path)
        {
            string pathFinal = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            pathFinal += "\\";
            pathFinal += path;
            pathFinal += ".csv";

            StreamWriter writer = new StreamWriter(pathFinal);
            string contenido = null;

            foreach (Alumno alumno in dato)
            {
                contenido = alumno.MostrarDatosParaCsv();
                writer.WriteLine(contenido);
                
            }
            writer.Close();
            return pathFinal;

        }

    }
}
