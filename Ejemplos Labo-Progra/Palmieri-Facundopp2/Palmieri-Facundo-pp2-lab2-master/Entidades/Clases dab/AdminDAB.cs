using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_dab
{
    public class AdminDAB
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;

        static AdminDAB()
        {
            //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True; otra forma de hacerlo
            _sqlConnection = new SqlConnection(@" Data source = .;
            DataBase = parcial_dos; 
            Trusted_Connection = true;");

            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;


        }

        public static List<Admin> traerUsuario()
        {
            List<Admin> list = new List<Admin>();
            try
            {
                _sqlCommand.CommandText = "select p.Dni,p.Apellido,p.Nombre,p.Contra,a.Id from persona p ,Admin a where p.Tipo_Id_Persona = 3 and p.Dni = a.Dni";

                _sqlConnection.Open();
                SqlDataReader reader = _sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Admin usuario = (Admin)reader;

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


        public static int AddAdmin(int Id,int Dni)
        {
            int filas = 0;
            try
            {
                _sqlConnection.Open();
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "insert into Admin (Id,Dni) values(@Id,@Dni)";
                _sqlCommand.Parameters.AddWithValue("@Id", Id);
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
