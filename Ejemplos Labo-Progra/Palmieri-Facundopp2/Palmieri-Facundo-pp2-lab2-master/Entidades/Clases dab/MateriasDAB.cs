using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_dab
{
    public class MateriasDAB
    {

        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;
        private static SqlCommand _sqlCommand2;
        //private static SqlConnection _sqlConnection2;


        static MateriasDAB()
        {
            //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True; otra forma de hacerlo
            _sqlConnection = new SqlConnection(@" Data source = .;
            DataBase = parcial_dos; 
            Trusted_Connection = true;");

            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;

        }

        public static List<Materia> traerMateria()
        {
            List<Materia> list = new List<Materia>();
            List<int> legajosAlumno = new List<int>();
            List<int> idProfe = new List<int>();
            SortedList<int, Parcial> parc = new SortedList<int, Parcial>();

            try
            {
                _sqlCommand.CommandText = "select m.Nombre,m.Cuatri,m.Id_Materia_Correlativa from Materias m";

                _sqlConnection.Open();
                SqlDataReader reader = _sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Materia materia = (Materia)reader;

                    parc = ParcialesDAB.traerParciales(materia.IdMateria);
                    legajosAlumno = AlumnosDAB.traerLegajoAlumnos(materia.IdMateria);

                    idProfe = ProfesoresDAB.traerIdProfesores(materia.IdMateria);

                    materia.AlumnosLegajo = legajosAlumno;
                   materia.IdProfesores = idProfe;
                    materia.Parciales = parc;

                    list.Add(materia);
                }

            }
            catch (Exception)
            {


            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
            return list;
        }

        public static int AddMateria(int Id_Materia, string Nombre,int Cuatri, int Id_Materia_Correlativa)
        {
            int filas = 0;
            try
            {
                _sqlConnection.Open();
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "insert into Materias (Id_Materia,Nombre,Cuatri,Id_Materia_Correlativa) values(@Id_Materia,@Nombre,@Cuatri,@Id_Materia_Correlativa)";
                _sqlCommand.Parameters.AddWithValue("@Id_Materia", Id_Materia);
                _sqlCommand.Parameters.AddWithValue("@Nombre", Nombre);    
                _sqlCommand.Parameters.AddWithValue("@Cuatri", Cuatri);
                _sqlCommand.Parameters.AddWithValue("@Id_Materia_Correlativa", Id_Materia_Correlativa);
                filas = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return filas;
        }


    }
}
