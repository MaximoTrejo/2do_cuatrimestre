using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace unit_testing
{
    [TestClass]
    public class UnitTest1
    {
 

        [TestMethod]
        public void testCheckTipoPersonaAlumnoCorrecto()
        {

            string respuesta = "Alumno";

            EstadoMateria mate1 = new EstadoMateria(1, eEstado.aprobado, 6, 8, 1, 1);
            EstadoMateria mate2 = new EstadoMateria(2, eEstado.aprobado, 6, 10, 1, 1);
            List<EstadoMateria> matePrimerAlumno = new List<EstadoMateria>();
            matePrimerAlumno.Add(mate1);
            matePrimerAlumno.Add(mate2);
            Persona alumno = new Alumno("Facundo", "Palmieri", 43803788, "F4cu", matePrimerAlumno);

            string tipo = ManejadorDeDatos.checkTipoPersona(alumno);

            Assert.AreEqual(tipo, respuesta);

        }
        [TestMethod]
        public void testCheckTipoPersonaAdminCorrecto()
        {

            string respuesta = "Admin";

            Persona admin = new Admin("Facundo", "Palmieri", 43803788, "F4cu");

            string tipo = ManejadorDeDatos.checkTipoPersona(admin);

            Assert.AreEqual(tipo, respuesta);

        }
        [TestMethod]
        public void testCheckTipoPersonaIncorrecto()
        {

            string respuesta = "no encontro";


            Persona persona = null;

            string tipo = ManejadorDeDatos.checkTipoPersona(persona);

            Assert.AreEqual(tipo, respuesta);

        }



    }
}
