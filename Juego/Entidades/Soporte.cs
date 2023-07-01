
namespace Entidades
{
    public static class Soporte
    {
        static AccesoDatos accesoDatos;
        static ArchivoJson<SalaJuego> archivoJson;
        static ArchivosXML<SalaJuego> archivosXML;

        public static ArchivoJson<SalaJuego> ArchivoJson { get => archivoJson; }
        public static ArchivosXML<SalaJuego> ArchivosXML { get => archivosXML; }

        static Soporte()
        {
            accesoDatos = new AccesoDatos();
            archivoJson = new ArchivoJson<SalaJuego>();
            archivosXML = new ArchivosXML<SalaJuego>();
        }

        public static List<Jugador> ObtenerValoresJugadores()
        {
            return accesoDatos.ObtenerListaDatoJugadores();
        }

        public static bool AgregarJugador(Jugador jugador)
        {
            return accesoDatos.AgregarDatoJugador(jugador);
        }

        public static bool ModificarJugador(Jugador jugador)
        {
            return accesoDatos.ModificarJugador(jugador);
        }
    }
}
