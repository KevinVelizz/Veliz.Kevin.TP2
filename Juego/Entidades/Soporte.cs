using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Soporte
    {
        static AccesoDatos AccesoDatos; 
        
        static Soporte()
        {
            AccesoDatos = new AccesoDatos();
        }

        public static void SubirJugador(Jugador jugador)
        {
            AccesoDatos.AgregarDatoJugador(jugador);
        }

        public static List<Jugador> ObtenerJugadores()
        {
            return AccesoDatos.ObtenerListaDatoJugadores();
        }

    }
}
