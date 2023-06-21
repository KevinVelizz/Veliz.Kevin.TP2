using System.Data;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;

namespace Entidades
{
    public class AccesoDatos
    {

        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;


        static AccesoDatos()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @".";
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "generala";
            AccesoDatos.cadena_conexion = builder.ConnectionString;
        }

        public AccesoDatos()
        {
            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }

        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                this.conexion.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return rta;
        }

        public List<Jugador> ObtenerListaDatoJugadores()
        {
            List<Jugador> lista = new List<Jugador>();
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT ID, Nombre,Puntos,Victorias,Turnos FROM Jugadores";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Jugador jugador = new Jugador(lector[1].ToString());
                    jugador.Id = (int)lector["id"];
                    jugador.Nombre = lector[1].ToString();
                    jugador.Puntaje = (int)lector[2];
                    jugador.Victorias = (int)lector[3];
                    jugador.Turnos = (int)lector[4];
                    lista.Add(jugador);
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return lista;
        }
      
        public bool AgregarDatoJugador(Jugador jugador)
        {
            bool rta = true;
            try
            {
                string sql = "INSERT INTO Jugadores (Nombre, Puntos, victorias, Turnos) VALUES(";
                sql = sql + "'" + jugador.Nombre.ToString() + "'," + jugador.Puntaje + "," + jugador.Victorias + "," + jugador.Turnos + ")";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;
                this.conexion.Open();
                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception e)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return rta;
        } 
    }
}
