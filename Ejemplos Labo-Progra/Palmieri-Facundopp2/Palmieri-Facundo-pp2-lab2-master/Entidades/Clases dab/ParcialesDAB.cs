using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_dab
{
    internal class ParcialesDAB
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;
        static ParcialesDAB()
        {
            //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True; otra forma de hacerlo
            _sqlConnection = new SqlConnection(@" Data source = .;
            DataBase = parcial_dos; 
            Trusted_Connection = true;");

            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;

        }

        public static SortedList<int, Parcial> traerParciales(int idMateria)
        {
            List<Profesor> list = new List<Profesor>();
            SortedList<int, Parcial> parc = new SortedList<int, Parcial>();
            try
            {
                _sqlCommand.CommandText = $"select p.Id_materia,p.Id_Profesor,p.Nombre_Parcial,p.Fecha_Parcial from Parciales p where p.Id_materia={idMateria}";

                _sqlConnection.Open();
                SqlDataReader reader = _sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Parcial parcial = (Parcial)reader;

                    parc.Add(parcial.Idparcial, parcial);
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
            return parc;
        }
    }
}
