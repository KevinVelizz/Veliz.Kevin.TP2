
namespace Entidades
{
    public static class Soporte
    {
        static AccesoDatos accesoDatos;
        static ArchivoJson<SalaJuego> archivoJson;
        static ArchivosXML<SalaJuego> archivosXML;
        static ArchivoJson<Usuario> usuariosJson;

        public static ArchivoJson<SalaJuego> ArchivoJson { get => archivoJson; }
        public static ArchivosXML<SalaJuego> ArchivosXML { get => archivosXML; }
        public static ArchivoJson<Usuario> UsuariosJson { get => usuariosJson; }

        static Soporte()
        {
            accesoDatos = new AccesoDatos();
            archivoJson = new ArchivoJson<SalaJuego>();
            archivosXML = new ArchivosXML<SalaJuego>();
            usuariosJson = new ArchivoJson<Usuario>();
        }

        /// <summary>
        /// El método accede al metodo de obtenerListaDatoJugadores y retornar la lista obtenida.
        /// </summary>
        /// <returns>Retorna la lista de jugadores obtenidas.</returns>
        public static List<Jugador> ObtenerValoresJugadores()
        {
            return accesoDatos.ObtenerListaDatoJugadores();
        }

        /// <summary>
        /// El método accede al método de AgregarDatoJugador y agrega un jugador a la tabla de la base de datos.
        /// </summary>
        /// <returns>Retorna true en caso de exito o false caso contrario.</returns>
        public static bool AgregarJugador(Jugador jugador)
        {
            return accesoDatos.AgregarDatoJugador(jugador);
        }


        /// <summary>
        /// El método accede al método de ModificarJugador y modificar un jugador a la tabla de la base de datos.
        /// </summary>
        /// <returns>Retorna true en caso de exito o false caso contrario.</returns>
        public static bool ModificarJugador(Jugador jugador)
        {
            return accesoDatos.ModificarJugador(jugador);
        }


      
    }
}
