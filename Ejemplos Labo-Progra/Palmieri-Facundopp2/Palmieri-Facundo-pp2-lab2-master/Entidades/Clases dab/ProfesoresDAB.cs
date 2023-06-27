using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades.Clases_dab
{
    public class ProfesoresDAB
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;
        static ProfesoresDAB()
        {
            //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True; otra forma de hacerlo
            _sqlConnection = new SqlConnection(@" Data source = .;
            DataBase = parcial_dos; 
            Trusted_Connection = true;");

            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;

        }

        public static List<Profesor> traerUsuario()
        {
            List<Profesor> list = new List<Profesor>();

            try
            {
                _sqlCommand.CommandText = "select p.Dni, p.Apellido, p.Nombre, p.Contra, a.Id_Profe from persona p, Profesores a where p.Tipo_Id_Persona = 2 and p.Dni = a.Dni";

                _sqlConnection.Open();
                SqlDataReader reader = _sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Profesor usuario = (Profesor)reader;

                    list.Add(usuario);
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


        public static List<int> traerIdProfesores(int idMateria)
        {
            List<int> list = new List<int>();
            try
            {
                _sqlCommand.CommandText = $"select p.Dni, p.Apellido, p.Nombre, p.Contra, a.Id_Profe from persona p, Profesores a,ProfesEnMaterias pm where p.Dni = a.Dni and pm.Id_Profe = a.Id_Profe and pm.Id_Materia = {idMateria}";

                _sqlConnection.Open();
                SqlDataReader reader = _sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Profesor prof = (Profesor)reader;

                    list.Add(prof.IdProf);
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


        public static int AddProfe(int Id_Profe, int Dni)
        {
            int filas = 0;
            try
            {
                _sqlConnection.Open();
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "insert into Profesores (Id_Profe,Dni) values(@Id_Profe,@Dni)";
                _sqlCommand.Parameters.AddWithValue("@Id_Profe", Id_Profe);
                _sqlCommand.Parameters.AddWithValue("@Dni", Dni);
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



