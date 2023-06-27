using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        protected string nombre;
        protected List<int> alumnosLegajo;
        protected List<int> idProfesores;
        protected int idMateria;
        protected int idMateriaCorrelativa;
        protected eCuatri cuatri;
        protected SortedList<int,Parcial> parciales;

        protected static int contIdMateria = 0;

        public Materia(int correlativa, string nombre, eCuatri cuatri)
        {
            contIdMateria++;
            this.idMateria = contIdMateria;
            idMateriaCorrelativa = correlativa;

            this.nombre = nombre;

            this.alumnosLegajo = new List<int>();
            this.idProfesores = new List<int>();
            this.parciales = new SortedList<int, Parcial>();

            this.cuatri = cuatri;
        }

        public Materia(int correlativa, string nombre, eCuatri cuatri, List<int> idProfesores) : this(correlativa, nombre, cuatri)
        {
            this.idProfesores = idProfesores;
        }

        public Materia(int correlativa, string nombre, eCuatri cuatri, List<int> idProfesores, List<int> alumnosLegajo, SortedList<int, Parcial> listaParciales):this(correlativa, nombre,cuatri, idProfesores)
        {
            this.alumnosLegajo = alumnosLegajo;
            this.parciales = listaParciales;
        }



        public string Nombre
        {
            get { return nombre; }
        }

        public int IdMateria
        {
            get { return idMateria; }
        }

        public int IdMateriaCorrelativa
        {
            get { return idMateriaCorrelativa; }
        }
        public SortedList<int, Parcial> Parciales
        {
            get { return parciales; }
            set { parciales = value; }
        }
        public List<int> IdProfesores
        {
            get { return idProfesores; }
            set { idProfesores = value; }
        }
        public List<int> AlumnosLegajo
        {
            get { return alumnosLegajo; }
            set { alumnosLegajo = value; }
        }
        /// <summary>
        /// Muestra los datos de una materia
        /// </summary>
        /// <returns>Un string con todos los datos de una materia</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre de la materia es:{nombre}");
            sb.AppendLine($"Id de la materia es:{idMateria}");
            if (idMateriaCorrelativa != -1)
            {
                sb.AppendLine($"Id de la materia correlativa es:{idMateriaCorrelativa}");
            }
            sb.AppendLine($"Pertenece al cuatrimestre :{cuatri}");

            return sb.ToString();
        }

        /// <summary>
        /// busca en una lista de materia el id de esa materia atrabes de su nombre
        /// </summary>
        /// <param name="Materia"></param>
        /// <param name="nombre"></param>
        /// <returns>devuelve el id de la materia o -1 si no encontro nada</returns>
        public int obteneridMateria(Materia Materia, string nombre)
        {
            int idProfesor = -1;
                if (Materia == nombre)
                {
                    idProfesor = Materia.IdMateria;
                }       
            return idProfesor;
        }


        /// <summary>
        /// Compara si el nombre de 2 materias es igual
        /// </summary>
        /// <param name="materia"></param>
        /// <param name="nomMateria"></param>
        /// <returns></returns>
        public static bool operator ==(Materia materia, string nomMateria)
        {
            return materia.Nombre == nomMateria;
        }
        public static bool operator !=(Materia materia, string nomMateria)
        {
            return !(materia == nomMateria);
        }


        public static explicit operator Materia(SqlDataReader v)
        {
            eCuatri cuatri = eCuatri.Curso_Ingreso;
            switch (v["Cuatri"])
            {
                case 0:
                    cuatri = eCuatri.Curso_Ingreso;
                    break;
                case 1:
                    cuatri = eCuatri.Primer_Cuatri;
                    break;
                case 2:
                    cuatri = eCuatri.Segundo_Cuatri;
                    break;
                case 3:
                    cuatri = eCuatri.Tercer_Cuatri;
                    break;           
                case 4:
                    cuatri = eCuatri.Cuarto_Cuatri;
                    break;
            }

            Materia u = new(Convert.ToInt32(v["Id_Materia_Correlativa"]),v["Nombre"].ToString(), cuatri);
            return u;
        }

    }
}
