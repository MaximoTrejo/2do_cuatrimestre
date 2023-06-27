using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Alumno :Persona
    {
       protected int legajo;
       protected List<EstadoMateria> materias;
       protected int cantMateriasDando;

        protected static int ContLegajo = 0;

        public Alumno(string nombre, string apellido, int dni, string password): base(nombre, apellido, dni, password)
        {
            ContLegajo++;
            this.legajo = ContLegajo;
            this.materias = new List<EstadoMateria>();

            this.cantMateriasDando = 0;
        }

        public Alumno(string nombre, string apellido, int dni, string password,int cantMateriasDando) : this(nombre, apellido, dni, password)
        {

            this.cantMateriasDando = cantMateriasDando;
        }


        public Alumno(string nombre, string apellido,int dni, string password, List<EstadoMateria> materias) : this(nombre, apellido, dni, password)
        {

            this.materias = materias;

        }

        public Alumno(string nombre, string apellido, int dni, string password, List<EstadoMateria> materias, int cantMateriasDando) : this(nombre, apellido, dni, password, materias)
        {

            this.cantMateriasDando=cantMateriasDando;
        }


        public int Legajo
        {
            get { return legajo; }
        }


        public int CantMateriasDando
        {
            get { return cantMateriasDando; }
            set { cantMateriasDando = value; }
        }
        public List<EstadoMateria> Materias
        {
            get { return materias; }
            set { materias = value; }
        }

        /// <summary>
        /// Sobrecarga el metodo MostrarDatos que esta creado en la clase padre(personas) y muestra todos los datos de un alumno
        /// </summary>
        /// <returns>Un string con todos los datos de un alumno</returns>
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"su legajo es:{Legajo}");
            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();
        }

        /// <summary>
        /// devuelve un string con las datos del alumno para luego separado de una coma
        /// </summary>
        /// <returns>Un string con todos los datos de un alumno</returns>
        public string MostrarDatosParaCsv()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Nombre},{Apellido},{Dni},{contra},{legajo},{cantMateriasDando}");

            return sb.ToString();
        }


        //string nombre, string apellido, int dni, string password, List<EstadoMateria> materias, int cantMateriasDando
        public static explicit operator Alumno(SqlDataReader v)
        {

            Alumno u = new(v["Nombre"].ToString(), v["Apellido"].ToString(), Convert.ToInt32(v["Dni"]), v["Contra"].ToString(), Convert.ToInt32(v["Cant_materias_dando"]));
             return u;
        }

    }
}
