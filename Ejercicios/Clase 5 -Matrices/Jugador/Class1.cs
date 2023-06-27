namespace Jugador
{
    public class Jugador
    {

        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;
        private Jugador()
        {
            this.dni=0;
            this.nombre="";
            this.partidosJugados=0;
            this.promedioGoles=0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre,int totalGoles,int totalPartidos) : this(dni,nombre)
        {
            this.totalGoles=totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public float getPromedioGoles()
        {
            return this.promedioGoles;
        }

        public string MostrarDatos() {

            string mensaje;

            mensaje = $"el dni es {this.dni} \nel nombre es {this.nombre} \npartidosJugados{this.partidosJugados} \npromedio goles{this.promedioGoles} \n total Goles{this.totalGoles} ";

            return mensaje;
        }

        public static bool operator == (Jugador j1, Jugador j2)
        {
            return (j1.dni == j2.dni);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.dni == j2.dni);
        }
    }
}