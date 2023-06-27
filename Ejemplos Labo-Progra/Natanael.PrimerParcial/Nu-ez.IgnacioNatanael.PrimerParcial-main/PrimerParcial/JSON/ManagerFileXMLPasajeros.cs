using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using Entidades;

namespace SerializarDeserializar
{
    public class ManagerFileXMLPasajeros
    {
        private static StreamReader? reader;

        public static int Serializar(string pathFile, List<Pasajero> listaDato)
        {
            #region Serializar
            // 1 Siempre primer Bien

            string path = Environment.CurrentDirectory + pathFile; // test + @"\datos\MOCK_DATA.json"
            //List<Pasajero>? listaDato = new List<Pasajero>();

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Pasajero>)));
                    ser.Serialize(writer, listaDato);

                    Console.WriteLine("ok al Serializar los Datos");
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error al Serializar los Datos");
                return 0;
            }
            #endregion
        }

        public static List<Pasajero> Deserializar(string pathFile)
        {
            #region Deserializar colecciones

            string path = Environment.CurrentDirectory + pathFile; // test + @"\datos\MOCK_DATA.json"
            List<Pasajero>? listaDato = new List<Pasajero>();

            try
            {
                using (XmlTextReader reader = new XmlTextReader(path))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Pasajero>)));

                    listaDato = (List<Pasajero>)ser.Deserialize(reader);
                    return listaDato;
                }
               /* foreach (T miDato in listaDato)
                {
                    Console.WriteLine(miDato.Mostrar());
                }*/

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error al Serializar/Deserializar los Datos");
                return null;
            }
            #endregion
        }

    }

}