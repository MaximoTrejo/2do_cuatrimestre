namespace Persona
{
    public class Personas
    {
        int fechaDeNacimiento;
        string nombre;
        int dni;
        //static int total; una variable estaticos se comparte con todos , por ejemplo si tengo un total de cartas y todos agarran , se resta de ese total
        public Personas(int fechaDeNacimiento,string nombre,int dni)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.nombre = nombre;
            this.dni = dni;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public int GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }

        public int GetDni()
        {
            return this.dni;
        }


        public int calcularEdad(Personas a1, int anio)
        {
            int edadCalc;

            edadCalc = anio - a1.fechaDeNacimiento;

            return edadCalc;
        }

        public string EsMayorDeEdad(int edadActual)
        {
            string mensaje;

            if (edadActual >= 18)
            {
                mensaje = "Es mayor de edad";
            }
            else 
            {
                mensaje = "Es menor";
            }
            return mensaje;
        }

        //public string saludar()
        public string mostrar(Personas a1)
        {
            string mensaje = $"el nombre es {a1.nombre} la fecha de nacimiento es {a1.fechaDeNacimiento} ,el dni es {a1.dni} y la edad actual es {calcularEdad(a1, 2023)} y {EsMayorDeEdad(calcularEdad(a1,2023))}";

            return mensaje;
        }
    }
}