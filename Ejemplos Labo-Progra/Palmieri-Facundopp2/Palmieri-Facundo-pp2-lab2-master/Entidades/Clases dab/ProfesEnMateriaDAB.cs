using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Entidades.Clases_dab
{
    public class ProfesEnMateriaDAB
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;
        static ProfesEnMateriaDAB()
        {
            //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True; otra forma de hacerlo
            _sqlConnection = new SqlConnection(@" Data source = .;
            DataBase = parcial_dos; 
            Trusted_Connection = true;");

            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;

        }
        public static int AddProfesEnMateria(int Id_Materia, int Id_Profe)
        {
            int filas = 0;
            try
            {
                _sqlConnection.Open();
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "insert into ProfesEnMaterias (Id_Materia,Id_Profe) values(@Id_Materia,@Id_Profe)";
                _sqlCommand.Parameters.AddWithValue("@Id_Materia", Id_Materia);
                _sqlCommand.Parameters.AddWithValue("@Id_Profe", Id_Profe);
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
