using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_dab
{
    public class EstadoMateriaDAB
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;
        static EstadoMateriaDAB()
        {
            //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True; otra forma de hacerlo
            _sqlConnection = new SqlConnection(@" Data source = .;
            DataBase = parcial_dos; 
            Trusted_Connection = true;");

            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;

        }

        public static List<EstadoMateria> traerUsuario(int legajo)
        {
            List<EstadoMateria> list = new List<EstadoMateria>();
            try
            {
                _sqlCommand.CommandText = $"SELECT e.Id_Materia,e.Nota_uno,e.Nota_Dos,e.Id_Parcial_Uno,e.Id_Parcial_Dos,e.Presente,e.Estado FROM EstadoMateria e where  e.Lejago_Alumno = {legajo}";

                _sqlConnection.Open();
                SqlDataReader reader = _sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    EstadoMateria estadoMateria = (EstadoMateria)reader;

                    list.Add(estadoMateria);
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


        public static int AddEstadoMateria(int Lejago_Alumno, int Id_Materia,int Presente,int Estado)
        {
            int filas = 0;
            try
            {
                _sqlConnection.Open();
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "insert into EstadoMateria (Lejago_Alumno,Id_Materia,Presente,Estado) values(@Lejago_Alumno,@Id_Materia,@Presente,@Estado)";
                _sqlCommand.Parameters.AddWithValue("@Lejago_Alumno", Lejago_Alumno);
                _sqlCommand.Parameters.AddWithValue("@Id_Materia", Id_Materia);
                _sqlCommand.Parameters.AddWithValue("@Presente", Presente);
                _sqlCommand.Parameters.AddWithValue("@Estado", Estado);
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

