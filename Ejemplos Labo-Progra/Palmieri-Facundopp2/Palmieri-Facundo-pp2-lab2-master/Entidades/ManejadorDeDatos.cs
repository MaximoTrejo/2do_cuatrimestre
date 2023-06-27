using Entidades.Clases_dab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ManejadorDeDatos
    {
        private static List<Persona> personas;
        private static List<Materia> materias;

        public static List<Persona> Personas { get => personas; }
        public static List<Materia> Materias { get => materias; }

        /// <summary>
        /// crea las lista de persona y materia
        /// </summary>
        static ManejadorDeDatos()
        {
            personas = new List<Persona>();
            materias = new List<Materia>();
            
           // CargarMaterias();
            cargarUsuariosDB();
            cargarMateriasDB();
           // CargarPersonas();
        }

        /// <summary>
        /// hardcodea algunas personas y las carga en la lista
        /// </summary>
        private static void CargarPersonas()
        {

            EstadoMateria mate1 = new EstadoMateria(1,  eEstado.aprobado, 6, 8, 1 ,1);
            EstadoMateria mate2 = new EstadoMateria(2,  eEstado.aprobado, 6, 10, 1, 1);

            EstadoMateria mate7 = new EstadoMateria(1,  eEstado.aprobado, 6, 8, 1 ,1);
            EstadoMateria mate3 = new EstadoMateria(2,  eEstado.Libre, 4, 2,2,2 );
            EstadoMateria mate4 = new EstadoMateria(3,  eEstado.Regular, 10, 6 ,3,3);

            EstadoMateria mate5 = new EstadoMateria(1,  eEstado.aprobado, 6, 6,1,1);
            EstadoMateria mate8 = new EstadoMateria(2, eEstado.Libre, 4, 2, 2, 2);
            EstadoMateria mate9 = new EstadoMateria(3, eEstado.Regular, 10, 6, 3, 3);
            EstadoMateria mate6 = new EstadoMateria(4,  eEstado.Cursando, 8, 10,4,4);

            List<EstadoMateria> matePrimerAlumno = new List<EstadoMateria>();
            List<EstadoMateria> mateSegundoAlumno = new List<EstadoMateria>();
            List<EstadoMateria> mateTercerAlumno = new List<EstadoMateria>();

            matePrimerAlumno.Add(mate1);
            matePrimerAlumno.Add(mate2);

            mateSegundoAlumno.Add(mate7);
            mateSegundoAlumno.Add(mate3);
            mateSegundoAlumno.Add(mate4);

            mateTercerAlumno.Add(mate5);
            mateTercerAlumno.Add(mate8);
            mateTercerAlumno.Add(mate9);
            mateTercerAlumno.Add(mate6);

            //Alumnos
            personas.Add(new Alumno("Facundo", "Palmieri", 43803788, "F4cu", matePrimerAlumno));
            personas.Add(new Alumno("Kevin", "Perez", 42001231, "k3v1", mateSegundoAlumno));
            personas.Add(new Alumno("Pedro", "Sanchez", 40603328, "pe", mateTercerAlumno));

            //profesores
            personas.Add(new Profesor("Lorena", "Dalbez", 32543782, "Lo.Da"));
            personas.Add(new Profesor("Juan", "Cerrazi", 39123243, "Ju.4n"));
            personas.Add(new Profesor("Pepe", "San", 37123451, "P3P3"));
            personas.Add(new Profesor("Jose", "Prado", 38332111, "4nt4rtid4"));
            //Admin
            personas.Add(new Admin("Hernesto", "Elbey", 32412341, "H33B"));
            personas.Add(new Admin("Claudio", "Bevilacqua", 38822123, "Cl4D4"));
            personas.Add(new Admin("Ezequiel", "Pastorini", 32112343, "EzeP4"));
        }
        /// <summary>
        /// hardcodea algunas materias y las carga en la lista
        /// </summary>
        private static void CargarMaterias()
        {
            Parcial par1 = new Parcial(1, new DateTime(2022, 08, 22), "Parcial introduccion a la programacion cuatri2", 1);
            Parcial par2 = new Parcial(2, new DateTime(2022, 08, 15), "Laboratorio I cuatri 2", 1);
            Parcial par3 = new Parcial(3, new DateTime(2022, 08, 8), "Laboratorio II cuatri 2", 1);
            Parcial par4 = new Parcial(4, new DateTime(2022, 08, 19), "Laboratorio III cuatri 2", 1);
            Parcial par5 = new Parcial(5, new DateTime(2022, 08, 21), "Programacion I cuatri 2", 1);

             SortedList<int, Parcial> ShorListParcial1 = new SortedList<int, Parcial>();
             SortedList<int, Parcial> ShorListParcial2 = new SortedList<int, Parcial>();
             SortedList<int, Parcial> ShorListParcial3 = new SortedList<int, Parcial>();
             SortedList<int, Parcial> ShorListParcial4 = new SortedList<int, Parcial>();
             SortedList<int, Parcial> ShorListParcial5 = new SortedList<int, Parcial>();

            ShorListParcial1.Add(1, par1);
            ShorListParcial2.Add(2, par2);
            ShorListParcial3.Add(3, par3);
            ShorListParcial4.Add(4, par4);
            ShorListParcial5.Add(5, par5);
            

            materias.Add(new Materia(0, "Introduccion a la Programacion", eCuatri.Curso_Ingreso, new List<int> { 1, 2 }, new List<int> { 1,3 }, ShorListParcial1));
            materias.Add(new Materia(1, "Laboratorio I", eCuatri.Primer_Cuatri, new List<int> { 1 , 2 }, new List<int> { 1, 2 }, ShorListParcial2));
            materias.Add(new Materia(2, "Laboratorio II", eCuatri.Segundo_Cuatri, new List<int> { 4 }, new List<int> { 2 }, ShorListParcial3));
            materias.Add(new Materia(3, "Laboratorio III", eCuatri.Tercer_Cuatri, new List<int> { 3 }, new List<int> { 3 }, ShorListParcial4));
            materias.Add(new Materia(1, "Programacio I", eCuatri.Tercer_Cuatri, new List<int> { 3 }, new List<int> (), ShorListParcial5));
        }


        //base de datos
        private static void cargarUsuariosDB()
        {
            var listAlumnos = AlumnosDAB.traerUsuario();
            var listaAdmin = AdminDAB.traerUsuario();
            var listaProfesor = ProfesoresDAB.traerUsuario();
            foreach (var item in listAlumnos)
            {
                personas.Add(item);
            }

            foreach (var item in listaAdmin)
            {
                personas.Add(item);
            }
            foreach (var item in listaProfesor)
            {
                personas.Add(item);
            }


        }

        private static void cargarMateriasDB()
        {
            var listaMateria = MateriasDAB.traerMateria();

            foreach (var item in listaMateria)
            {
                materias.Add(item);
            }

        }


        /// <summary>
        /// se fija que el login sea correcto y que exista una persona con ese dni y esa contraseña
        /// </summary>
        /// <param name="dni">tipo int es el dni</param>
        /// <param name="contra">tipo string es la contraseña</param>
        /// <returns></returns>
        public static Persona checkLogin(int dni, string contra)
        {
            foreach (Persona item in Personas)
            {
                if (item.Dni == dni && item.checkContra(contra))
                {
                    return item;
                }
            }

            return null;
        }


        /// <summary>
        /// Esta funcion te dice de que tipo es mi persona
        /// si es un admin un alumno o un profesor
        /// </summary>
        /// <param name="miPersona">Le pasa la persona que quiere saber el tipo </param>
        /// <returns>retorna un string con el nombre del tìpo</returns>
        public static string checkTipoPersona(Persona miPersona)
        {
            string tipo = "no encontro";

            if (miPersona is not null) {
                if (miPersona.GetType() == typeof(Alumno))
                {
                    tipo = "Alumno";
                }
                else if (miPersona.GetType() == typeof(Profesor))
                {
                    tipo = "Profesor";

                }
                else if (miPersona.GetType() == typeof(Admin))
                {
                    tipo = "Admin";
                }
            }
            return tipo;
        }

        /// <summary>
        /// esta funcion busca que no se repita el dni en la lista
        /// </summary>
        /// <param name="dni">Es el dni que van a comparar para que no se repita con ningun otro dni </param>
        /// <returns> Si retorno true es que no hay un DNI con ese numero
        ///           si retorno false es que hay un DNI con ese numero</returns>
        public static bool dniUnico(int dni)
        {
            bool retorno = true;
            foreach (Persona item in Personas)
            {
                if (item.Dni == dni)
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// agrega una persona de tipo alumno a la lista de personas
        /// </summary>
        /// <param name="miAlumno">una persona de tipo alumno</param>
        public static void CargarPersonaEnLista(Alumno miAlumno)
        {

            if (miAlumno is not null)
            {
                personas.Add(miAlumno);
            }

        }

        /// <summary>
        /// agrega una persona de tipo admin a la lista de personas
        /// </summary>
        /// <param name="miAlumno">una persona de tipo admin</param>
        public static void CargarPersonaEnLista(Admin miAlumno)
        {

            if (miAlumno is not null)
            {
                personas.Add(miAlumno);
            }

        }


        /// <summary>
        /// agrega una persona de tipo profesor a la lista de personas
        /// </summary>
        /// <param name="miAlumno">una persona de tipo profesor</param>
        public static void CargarPersonaEnLista(Profesor miAlumno)
        {

            if (miAlumno is not null)
            {
                personas.Add(miAlumno);
            }

        }


        /// <summary>
        /// agrega una materia a la lista de materia
        /// </summary>
        /// <param name="miMateria">la materia que se quiere agregar</param>
        public static void CargarMateriaEnLista(Materia miMateria)
        {

            if (miMateria is not null)
            {
                materias.Add(miMateria);
            }

        }

        /// <summary>
        /// funcion para obtener la lista de materias
        /// </summary>
        /// <returns>devuelve una list de tipo string con todas las materias que hay en la lista</returns>
        public static List<string> obtenerMaterias()
        {
            List<string> list = new List<string>();

            foreach (Materia item in materias)
            {
                list.Add(item.Nombre);
            }
            return list;
        }

        /// <summary>
        /// funcion para obtener una lista de profesores
        /// </summary>
        /// <returns>>devuelve una list de tipo string con todas los profesores que hay en la lista</returns>
        public static List<string> obtenerProfesores()
        {
            List<string> list = new List<string>();
            string tipo;
            foreach (Persona item in personas)
            {
                tipo = checkTipoPersona(item);
                if (tipo == "Profesor")
                {
                    list.Add(item.Nombre + " " + item.Apellido);
                }
            }
            return list;
        }

        /// <summary>
        /// funcion para buscar el numero de correlativa para la materia que se esta creando
        /// </summary>
        /// <param name="nomreMateria">nombre de la materia que es la padre de la nueva materia</param>
        /// <returns>devuelve el id de la materia correlativa</returns>
        public static int numCorrelativa(string nomreMateria)
        {
            int numCorrelativa = 0;

            for (int i = 0; i < materias.Count; i++)
            {
                if (materias[i] == nomreMateria)
                {
                    numCorrelativa = materias[i].IdMateria;
                    break;
                }
            }
            return numCorrelativa;
        }


        /// <summary>
        /// funcion para obtener el id de un profesor atravez de su nombre
        /// </summary>
        /// <param name="nombre">el nombre del profesor</param>
        /// <returns>devuelve el id del profesor</returns>
        public static int obtenerIdProfesor(string nombre)
        {
            int idProfesor = -1;
            Profesor profe;
            foreach (Persona item in personas)
            {
                if (checkTipoPersona(item) == "Profesor")
                {
                    profe = (Profesor)item;
                    idProfesor = profe.obtenerIdProfesor(profe, nombre);
                    if (idProfesor != -1)
                    {

                        break;
                    }
                }
            }
            return idProfesor;
        }

        /// <summary>
        /// funcion para conseguir el id de una materia
        /// </summary>
        /// <param name="nombre">el nombre de la materia</param>
        /// <returns>devuelve el id de la materia</returns>
        public static int obtenerIdMateria(string nombre)
        {
            int idMateria = -1;
            foreach (Materia item in materias)
            {
                idMateria = item.obteneridMateria(item, nombre);
                if (idMateria != -1)
                {
                    break;
                }
            }
            return idMateria;
        }


        /// <summary>
        /// actualiza la lista de profesores del objeto de materia
        /// </summary>
        /// <param name="idMateria">el id de la materia para saber que objeto es</param>
        /// <param name="idProfe">el id de la materia para saber que profesor es</param>
        /// <returns>devuelve true si se puedo agregar a la lista de profesores de la materia 
        /// o devuelve false si no se pudo</returns>
        public static bool actualizarMateriaEnLista(int idMateria, int idProfe)
        {
            bool Retorno = false;
            foreach (Materia item in materias)
            {
                if (idMateria == item.IdMateria)
                {
                    if (item.IdProfesores.Count == 0)
                    {
                        Retorno = true;
                        item.IdProfesores.Add(idProfe);
                        break;
                    }
                    else
                    {
                        foreach (int profeId in item.IdProfesores)
                        {
                            if (profeId == idProfe)
                            {
                                Retorno = false;
                                break;
                            }
                            else
                            {
                                Retorno = true;
                                item.IdProfesores.Add(idProfe);
                                break;

                            }
                        }
                    }
                }
            }
            return Retorno;
        }

        /// <summary>
        /// Busca si el alumno ya esta en la materia
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="idMateria"></param>
        /// <returns>true si el alumno no esta en la materia
        /// false si el alumno ya esta en la materia</returns>
        public static bool EstaEnLaMateria(Alumno alumno, int idMateria)
        {
            bool retorno = false;
            string tipo;
            Alumno auxAlumno;

            if (alumno is not null && idMateria >= 0)
            {
                foreach (Persona item in personas)
                {
                    tipo = checkTipoPersona(item);
                    if (tipo == "Alumno")
                    {
                        auxAlumno = (Alumno)item;

                        if (auxAlumno.Legajo == alumno.Legajo)
                        {
                            if(auxAlumno.Materias.Count > 0)
                            {
                                foreach (EstadoMateria itemMaterias in auxAlumno.Materias)
                                {
                                    if (itemMaterias.IdMateria == idMateria)
                                    {
                                        retorno = false;
                                        break;
                                    }
                                    else
                                    {
                                        retorno = true;
                                    }
                                }
                            }
                            else
                            {
                                retorno = true;

                            }

                            break;
                        }
                    }
                }
            }
            return retorno;
        }


        /// <summary>
        /// obtiene los id de los profesores que dan una materia
        /// </summary>
        /// <param name="idMateria"></param>
        /// <returns>devuelve una lista de tipo int con los id de los profesores</returns>
        public static List<int> obtenerIdProfesoresDeUnaMateria(int idMateria)
        {
            foreach (Materia item in materias)
            {
                if (item.IdMateria == idMateria)
                {
                    return item.IdProfesores;
                }
            }
            return null;
        }
        /// <summary>
        /// obtiene los id de los alumnos que dan la materia
        /// </summary>
        /// <param name="idMateria"></param>
        /// <returns>devuelve una lista de tipo int con los id de los alumnos</returns>
        public static List<int> obtenerAlumnosPorIdMateria(int idMateria)
        {
            List<int> listaLejago = new List<int>();
            foreach (Materia item in materias)
            {
                if (item.IdMateria == idMateria)
                {
                    listaLejago = item.AlumnosLegajo;
                   
                }
            }
            return listaLejago;
        }

        /// <summary>
        /// esta funcion sirve para obtener los nombres de los profesores atravez de una lista de los id de los profesores
        /// </summary>
        /// <param name="listaProfes"></param>
        /// <returns>Una lista de tipo string que devuelve los nombres</returns>
        public static List<string> obtenerNombreDeProfesoresPorIdProfe(List<int> listaIdProfes)
        {
            List<string> nombresProfes = new List<string>();
            Profesor auxProfe;
            foreach (Persona persona in personas)
            {
                if (checkTipoPersona(persona) == "Profesor")
                {
                    auxProfe = (Profesor)persona;
                    foreach (int item in listaIdProfes)
                    {
                        if (auxProfe.IdProf == item)
                        {
                            nombresProfes.Add(auxProfe.Nombre + " " + auxProfe.Apellido);
                        }
                    }
                }
            }
            return nombresProfes;
        }


        /// <summary>
        /// esta funcion sirve para obtener los nombres de los alumnos atravez de una lista de los id de los alumnos
        /// </summary>
        /// <param name="listaProfes"></param>
        /// <returns>Una lista de tipo string que devuelve los nombres</returns>
        public static List<string> obtenerNombreDeAlumnosPorSuLegajo(List<int> listaLegajo)
        {
            List<string> nombresProfes = new List<string>();
            Alumno auxAlumno;
            foreach (Persona persona in personas)
            {
                if (checkTipoPersona(persona) == "Alumno")
                {
                    auxAlumno = (Alumno)persona;
                    foreach (int item in listaLegajo)
                    {
                        if (auxAlumno.Legajo == item)
                        {
                            nombresProfes.Add(auxAlumno.Nombre + " " + auxAlumno.Apellido);
                        }
                    }
                }
            }
            return nombresProfes;
        }

        /// <summary>
        /// esta funcion sirve para obtener los parcilaes de una materia
        /// </summary>
        /// <param name="listaProfes"></param>
        /// <returns>Una lista de tipo string que devuelve el nombre de los parciales</returns>
        public static List<string> obtenerNombresParciales(int idMateria, int idProfe)
        {
            List<string> nombresParciales = new List<string>();
            foreach (Materia materia in materias)
            {
                if (materia.IdMateria == idMateria)
                {
                    foreach (var item in materia.Parciales)
                    {
                        
                        if (item.Value.IdProfe == idProfe)
                        {
                            nombresParciales.Add(item.Value.NombreParcial);
                        }
                    }
                }
                
            }
            return nombresParciales;
        }

        /// <summary>
        /// Obtiene el id del parcial por el nombre del parcial
        /// </summary>
        /// <param name="nombreParcial"></param>
        /// <param name="idMateria"></param>
        /// <returns>retorna -1 si no se encuentra el parcial, sino devuelve el id del parcial</returns>
        public static int obtenerIdParcialPorNombre(string nombreParcial, int idMateria)
        {
            int idParcial = -1;
            foreach (Materia materia in materias)
            {
                if (materia.IdMateria == idMateria)
                {
                    foreach (var item in materia.Parciales)
                    {

                        if (item.Value.NombreParcial == nombreParcial)
                        {
                            idParcial = item.Value.Idparcial;
                            break;
                        }
                    }
                }

            }
            return idParcial;
        }

        /// <summary>
        /// actualiza la lista de persona
        /// </summary>
        /// <param name="usuarioLogueado"></param>
        public static void actualizarListaPersona(Persona usuarioLogueado)
        {
            Alumno auxAlumnoLogueado = (Alumno)usuarioLogueado;
            Alumno auxAlumno;
            foreach (Persona persona in Personas)
            {
                if (checkTipoPersona(persona) == "Alumno")
                {
                    auxAlumno = (Alumno)persona;
                    if (auxAlumno.Legajo == auxAlumnoLogueado.Legajo)
                    {
                        auxAlumno = auxAlumnoLogueado;
                    }
                }
            }
        }

        /// <summary>
        /// actualiza la lista de materia agregando a una materia en su lista de persona la materia
        /// </summary>
        /// <param name="usuarioLogueado"></param>
        /// <param name="idMateria"></param>
        public static void actualizarListaMateria(Persona usuarioLogueado,int idMateria)
        {
            Alumno auxAlumnoLogueado = (Alumno)usuarioLogueado;
            
            foreach (Materia materia in materias)
            {
                if (idMateria == materia.IdMateria)
                {
                    materia.AlumnosLegajo.Add(auxAlumnoLogueado.Legajo);
                    break;
                }
            }
        }

        /// <summary>
        /// Funcion para obtener las materias que da un profesor
        /// </summary>
        /// <param name="idProfe"></param>
        /// <returns>Una lista de tipo string con el nombre de las materias que da</returns>
        public static List<string> obtenerMateriaPorProfesor(int idProfe)
        {
            List<string> nombresMateria = new List<string>();

            foreach (Materia materia in materias)
            {
                foreach (int materiaProfesor in materia.IdProfesores)
                {
                    if (materiaProfesor == idProfe)
                    {
                        nombresMateria.Add(materia.Nombre);
                    }
                }
            }
            return nombresMateria;
        }

        /// <summary>
        /// Funcion para obtener las materias que curso o cursa un alumno
        /// </summary>
        /// <param name="legajoAlumno"></param>
        /// <returns>Una lista de tipo string con el nombre de las materias</returns>
        public static List<string> obtenerMateriaPorAlumno(int legajoAlumno)
        {
            List<string> nombresMateria = new List<string>();      
            
            
            foreach (Materia materia in materias)
            {
                foreach (int materiaAlumnoLegajo in materia.AlumnosLegajo)
                {
                    if (materiaAlumnoLegajo == legajoAlumno)
                    {
                        nombresMateria.Add(materia.Nombre);
                    }
                }
            }
            return nombresMateria;
        }


        /// <summary>
        /// Busca a los alumno de una materia
        /// </summary>
        /// <param name="idMateria"></param>
        /// <returns>Una lista de tipo string con los nombres de los alumnos</returns>
        public static List<string> obtenerAlumnosPorMateria(int idMateria)
        {
            List<string> nombresAlumno = new List<string>();
            string nombreCompleto;
            Alumno auxAlumno;
            foreach (Materia materia in materias)
            {
                if (materia.IdMateria == idMateria)
                {
                    foreach (int item in materia.AlumnosLegajo)
                    {
                        foreach (Persona alumno in personas)
                        {
                            if (checkTipoPersona(alumno) == "Alumno")
                            {
                                auxAlumno = (Alumno)alumno;
                                if(item == auxAlumno.Legajo  )
                                {
                                    nombreCompleto = auxAlumno.Nombre + " "+ auxAlumno.Apellido;
                                    nombresAlumno.Add(nombreCompleto);
                                }
                            }
                        }
                    }
                }
            }
            return nombresAlumno;
        }

        /// <summary>
        /// Esta funcion es para obtener el nombre de la materia atravez de su id
        /// </summary>
        /// <param name="idMateria"></param>
        /// <returns>devuel un string con el nombre de la materia</returns>
        public static string obtenerMateriaPorId(int idMateria)
        {
            string nombre = null;
            foreach (Materia materia in materias)
            {
                    if (materia.IdMateria == idMateria)
                    {
                        nombre= materia.Nombre;
                        break;
                    }                
            }
            return nombre;
        }

        /// <summary>
        /// busca el estado materia de la lista de alumnos
        /// </summary>
        /// <param name="idMateria"></param>
        /// <returns>devuelve el estado de la materia</returns>
        public static EstadoMateria obtenerEstadoMateria(int idMateria,int LegajoAlumno)
        {
            EstadoMateria estadMateria = null;
            Alumno alumno = null;
            foreach (Persona persona in personas)
            {
                if (checkTipoPersona(persona) == "Alumno")
                {
                    alumno = (Alumno)persona;
                    if (alumno.Materias.Count > 0 )
                    {
                        if(LegajoAlumno == alumno.Legajo)
                        {
                            foreach (EstadoMateria item in alumno.Materias)
                            {
                                if (item.IdMateria == idMateria)
                                {
                                    estadMateria = item;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return estadMateria;
        }



        /// <summary>
        /// Agregar un parcial a la SortedList de parciales de la materia
        /// </summary>
        /// <param name="parcial"></param>
        /// <returns>true si se agrego correctamente, falsa si no se agrego</returns>
        public static bool agregarUnParcial(Parcial parcial)
        {
            bool retorno = false;
            if (parcial != null)
            {
                foreach (Materia materia in materias)
                {
                    if(materia.IdMateria == parcial.Idmateria)
                    {
                        materia.Parciales.Add(parcial.Idparcial, parcial);
                        retorno = true; 
                        break;
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// Actualiza las notas de un alumno
        /// </summary>
        /// <param name="estadoNuevo"></param>
        /// <param name="LegajoPersona"></param>
        /// <returns>devuelve false si no lo pudo hacer, devuelve true si se pudo hacer</returns>
        public static bool ActualizarEstadoMateria(EstadoMateria estadoNuevo,int LegajoPersona)
        {
            bool retorno = false;
            Alumno auxAlumno;
            if (estadoNuevo != null)
            {
                foreach (Persona itemPersona in personas)
                {
                    if (checkTipoPersona(itemPersona) == "Alumno")
                    {
                        auxAlumno = (Alumno)itemPersona;
                        if (auxAlumno.Legajo == LegajoPersona)
                        {
                            foreach (EstadoMateria item in auxAlumno.Materias)
                            {
                                if (item.IdMateria == estadoNuevo.IdMateria)
                                {
                                    item.IdParcialUno = estadoNuevo.IdParcialUno;
                                    item.IdParcialDos = estadoNuevo.IdParcialDos;
                                    item.NotaUno = estadoNuevo.NotaUno;
                                    item.NotaDos = estadoNuevo.NotaDos;
                                    item.Estado_Materia = estadoNuevo.Estado_Materia;
                                    item.Presente = estadoNuevo.Presente;
                                    retorno = true;
                                    break;
                                }
                            }

                        }
                    }
                }
            }
            return retorno;
        }


        /// <summary>
        /// obtiene el legajo por el nombre y apellido del usuario
        /// </summary>
        /// <param name="nombreCompleto"></param>
        /// <returns>devuelve un int con el legajo si encontro al alumno, si no devuelve -1</returns>
        public static int ObtenerLegajoPorNombre(string nombreCompleto)
        {
            int retorno = -1;
            string nombreFull;
            Alumno auxAlumno;
            foreach (Persona persona in personas)
            {
                if (checkTipoPersona(persona) == "Alumno")
                {
                    auxAlumno = (Alumno)persona;
                    nombreFull = auxAlumno.Nombre + " " + auxAlumno.Apellido;
                    if (nombreFull == nombreCompleto)
                    {
                        retorno = auxAlumno.Legajo;
                    }
                }
            }
            return retorno;
        }

        public static bool DioLaCorrelativa(List<EstadoMateria> estadoMaterias,int idMateria)
        {
            bool retorno = false;
            int idCorrelativa=-1;
            foreach (Materia item in materias)
            {
                if(item.IdMateria == idMateria)
                {
                    idCorrelativa = item.IdMateriaCorrelativa;
                    break;
                }
            }

            if (idCorrelativa == 0)
            {
                retorno=true;
            }
            else if(idCorrelativa != -1)
            {
                foreach (EstadoMateria item in estadoMaterias)
                {
                    if (item.IdMateria == idCorrelativa && item.Estado_Materia == eEstado.aprobado)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// funcion para obtener la lista de Alumnos
        /// </summary>
        /// <returns>devuelve una list de tipo string con todas los alumnos que hay en la lista</returns>
        public static List<string> obtenerAlumnos()
        {
            List<string> list = new List<string>();
            string nombreCompleto;
            foreach (Persona item in personas)
            {
                if (checkTipoPersona(item) == "Alumno")
                {
                    nombreCompleto = item.Nombre + " " + item.Apellido;
                    list.Add(nombreCompleto);

                }
            }
            return list;
        }

        /// <summary>
        /// Obtiene un alumno por el nombre del usuario
        /// </summary>
        /// <param name="nombreCompletoAlumno"></param>
        /// <returns>devuelve el alumno si se encuentra, si no se devuelve un alumno null</returns>
        public static Alumno obtenerAlumnosPorNombre(string nombreCompletoAlumno)
        {
            string nombreCompleto;
            Alumno retorno =null;
            Alumno aux;
            foreach (Persona item in personas)
            {
                if (checkTipoPersona(item) == "Alumno")
                {
                    aux=(Alumno)item;
                    nombreCompleto = item.Nombre + " " + item.Apellido;
                    if(nombreCompleto == nombreCompletoAlumno)
                    {
                        retorno = aux;
                        break;
                    }
                }

            }
            return retorno;
        }



        public static List<Alumno> obtenerAlumnosTodosDatosPorMateria(int idMateria)
        {
            List<Alumno> nombresAlumno = new List<Alumno>();
            string nombreCompleto;
            Alumno auxAlumno;
            foreach (Materia materia in materias)
            {
                if (materia.IdMateria == idMateria)
                {
                    foreach (int item in materia.AlumnosLegajo)
                    {
                        foreach (Persona alumno in personas)
                        {
                            if (checkTipoPersona(alumno) == "Alumno")
                            {
                                auxAlumno = (Alumno)alumno;
                               
                                    nombresAlumno.Add(auxAlumno);
                                
                            }
                        }
                    }
                }
            }
            return nombresAlumno;
        }

    }
}
