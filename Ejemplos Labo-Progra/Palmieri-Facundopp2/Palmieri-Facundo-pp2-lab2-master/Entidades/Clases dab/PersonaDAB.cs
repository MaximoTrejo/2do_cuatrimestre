using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_dab
{
    public class PersonaDAB
    {

        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;



        static PersonaDAB()
        {
            //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True; otra forma de hacerlo
            _sqlConnection = new SqlConnection(@" Data source = .;
            DataBase = parcial_dos; 
            Trusted_Connection = true;");

            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;

        }

        public static int AddPersona(int Dni,string Apellido, string Nombre,string Contra, int Tipo)
            {
            int filas = 0;
            try
            {
                _sqlConnection.Open();
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "insert into Persona (Dni,Apellido,Nombre,Contra,Tipo_Id_Persona) values(@Dni,@Apellido,@Nombre,@Contra,@Tipo)";
                _sqlCommand.Parameters.AddWithValue("@Dni", Dni);
                _sqlCommand.Parameters.AddWithValue("@Apellido", Apellido);
                _sqlCommand.Parameters.AddWithValue("@Nombre", Nombre);
                _sqlCommand.Parameters.AddWithValue("@Contra", Contra);
                _sqlCommand.Parameters.AddWithValue("@Tipo", Tipo);
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
