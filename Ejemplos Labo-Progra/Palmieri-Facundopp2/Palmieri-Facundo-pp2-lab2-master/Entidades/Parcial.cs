using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Parcial
    {
        private static int idCont = 0;
        protected int idParcial;
        protected int idMateria;
        protected int idProfe;
        protected string nombreParcial;
        protected DateTime fecheParcial;

        public Parcial(int idMateria, DateTime fecheParcial, string nombreParcial,int idProfe)
        {
            idCont++;
            this.idParcial = idCont;
            this.idMateria = idMateria;
            this.fecheParcial = fecheParcial;
            this.nombreParcial = nombreParcial;
            this.idProfe = idProfe;
        }

        public int Idmateria
        {
            get { return idMateria; }
            set { idMateria = value; }
        }

        public int IdProfe
        {
            get { return idProfe; }
            set { idProfe = value; }
        }
        public int Idparcial
        {
            get { return idParcial; }
            set { idParcial = value; }
        }

        public string NombreParcial
        {
            get { return nombreParcial; }
            set { nombreParcial = value; }
        }

        //int idMateria, DateTime fecheParcial, string nombreParcial,int idProfe
        public static explicit operator Parcial(SqlDataReader v)
        {
            Parcial u = new(Convert.ToInt32(v["Id_materia"]), Convert.ToDateTime(v["Fecha_Parcial"]), v["Nombre_Parcial"].ToString(), Convert.ToInt32(v["Id_Profesor"]));
            return u;

        }

        /// <summary>
        /// Crea un string con todos los datos para crear el parcial
        /// </summary>
        /// <returns>string con datos sobre el parcial</returns>
        public string mostrarParcial()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(nombreParcial);
            sb.Append(fecheParcial);
            return sb.ToString();
        }
    }
}
