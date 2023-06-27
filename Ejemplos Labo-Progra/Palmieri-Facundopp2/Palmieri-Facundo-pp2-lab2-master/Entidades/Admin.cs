using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Admin : Persona
    {
        protected int idAdmin;

        protected static int contAdmin = 0;

        public Admin(string nombre, string apellido,  int dni, string password) : base(nombre, apellido, dni, password)
        {
            contAdmin++; 
            this.idAdmin = contAdmin; 
        }


        public int IdAdmin
        {
            get { return idAdmin; }
        }
        
        /// <summary>
        /// Sobrecarga el metodo MostrarDatos que esta creado en la clase padre(personas) y muestra todos los datos de un admin
        /// </summary>
        /// <returns>Un string con todos los datos de un admin</returns>
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"su Id de administrador es:{idAdmin}");
            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();
        }

        public static explicit operator Admin(SqlDataReader v)
        {

            Admin u = new(v["Nombre"].ToString(), v["Apellido"].ToString(), Convert.ToInt32(v["Dni"]), v["Contra"].ToString());
            return u;
        }
    }
}
