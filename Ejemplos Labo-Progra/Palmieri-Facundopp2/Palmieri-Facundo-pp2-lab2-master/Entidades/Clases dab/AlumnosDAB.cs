using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades.Clases_dab
{
    public class AlumnosDAB
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;
        static AlumnosDAB()
        {
            //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True; otra forma de hacerlo
            _sqlConnection = new SqlConnection(@" Data source = .;
            DataBase = parcial_dos; 
            Trusted_Connection = true;");

            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;


        }

        public static List<Alumno> traerUsuario()
        {
            List<Alumno> list = new List<Alumno>();
            List<EstadoMateria> listaEstado = new List<EstadoMateria>();
            try
            {
                _sqlCommand.CommandText = "select p.Dni,p.Apellido,p.Nombre,p.Contra,a.Legajo,a.Cant_materias_dando from persona p ,Alumno a where p.Tipo_Id_Persona = 1 and p.Dni = a.Dni";

                _sqlConnection.Open();
                SqlDataReader reader = _sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Alumno usuario = (Alumno)reader;

                    listaEstado = EstadoMateriaDAB.traerUsuario(usuario.Legajo);

                    usuario.Materias = listaEstado;

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


        public static List<int> traerLegajoAlumnos(int idMateria)
        {
            List<int> list = new List<int>();
            try
            {
                _sqlCommand.CommandText = $"select p.Nombre,p.Apellido,p.Dni,p.Contra,a.Cant_materias_dando from EstadoMateria em,Alumno a,persona p where em.Id_Materia = {idMateria} and a.Legajo = em.Lejago_Alumno and p.Tipo_Id_Persona = 1 and p.Dni = a.Dni";

                _sqlConnection.Open();
                SqlDataReader reader = _sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Alumno Alum = (Alumno)reader;

                    list.Add(Alum.Legajo);
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

        public static int AddAlumno(int Legajo, int Cant_materias_dando,int Dni)
        {
            int filas = 0;
            try
            {
                _sqlConnection.Open();
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "insert into Alumno (Legajo,Cant_materias_dando,Dni) values(@Legajo,@Cant_materias_dando,@Dni)";
                _sqlCommand.Parameters.AddWithValue("@Legajo", Legajo);
                _sqlCommand.Parameters.AddWithValue("@Cant_materias_dando", Cant_materias_dando);
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
