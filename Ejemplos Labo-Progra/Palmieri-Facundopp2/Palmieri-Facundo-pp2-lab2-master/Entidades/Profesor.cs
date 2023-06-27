using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        protected int idProf;
       

        protected static int contIdProfe=0;

        public Profesor(string nombre, string apellido,  int dni, string password) : base(nombre, apellido,dni, password)
        {
            contIdProfe++;
            this.idProf = contIdProfe;

        }

        public int IdProf
        {
            get { return idProf; }
        }



        /// <summary>
        /// Sobrecarga el metodo MostrarDatos que esta creado en la clase padre(personas) y muestra todos los datos de un Profesor
        /// </summary>
        /// <returns>Un string con todos los datos de un profesor</returns>
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"su legajo es:{IdProf}");
            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();
        }

        public static explicit operator Profesor(SqlDataReader v)
        {
            Profesor u = new(v["Nombre"].ToString(), v["Apellido"].ToString(), Convert.ToInt32(v["Dni"]), v["Contra"].ToString());
            return u;
        }

        /// <summary>
        /// Busca el id de un profesor atravez de su nombre completo
        /// </summary>
        /// <param name="Profesore"></param>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public int obtenerIdProfesor(Profesor Profesore, string nombre)
        {
            int idProfesor = -1;

           
                if (Profesore == nombre)
                {
                    idProfesor = Profesore.IdProf;
                }
            
            return idProfesor;
        }

        /// <summary>
        /// Compara si mi profesor tiene el mismo nombre que le pase
        /// </summary>
        /// <param name="profesor"></param>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static bool operator == (Profesor profesor, string nombreCompl)
        {
            string nombreCompleto = profesor.Nombre + " " + profesor.apellido;
            return nombreCompleto == nombreCompl;
        }
        public static bool operator != (Profesor profesor, string nombreCompl)
        {
            return !(profesor == nombreCompl);
        }

    }
}
