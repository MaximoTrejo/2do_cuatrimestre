using Jugador;

namespace Equipo
{
    public class Equipo
    {
        short cantidadDeJugadores;
        List<Jugador.Jugador> jugadores;
        string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador.Jugador>();
        }

        public Equipo(short cantidad, string nombre):this()         
        {
            this.cantidadDeJugadores =cantidad;
            this.nombre = nombre;
        }


        //
        public static bool operator +(Equipo e, Jugador.Jugador j)
        {
            bool respuesta = false;

            if (e.jugadores.Count <= e.cantidadDeJugadores)
            {
                
                if (e.jugadores.Count == 0)
                {
                    
                    e.jugadores.Add(j);
                    respuesta = true;
                }
                else
                {
                    foreach (Jugador.Jugador i in e.jugadores)
                    {
                        
                        if (i != j)
                        {
                            
                            respuesta = true;
                            e.jugadores.Add(j);
                            break;

                        }
                    }
                }
                //e.jugadores.Add(j);

            }
            return respuesta;
        }

    }
}