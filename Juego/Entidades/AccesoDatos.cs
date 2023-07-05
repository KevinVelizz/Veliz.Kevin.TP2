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
            builder.InitialCatalog = "generala_db";
            AccesoDatos.cadena_conexion = builder.ConnectionString;
            //builder.UserID = "sa";
            //builder.Password = "alumno";

            //AccesoDatos.cadena_conexion = @"Server=localhost\SQLEXPRESS;Database=Test;Trusted_Connection=True;";
        }

        public AccesoDatos()
        {
            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }

        /// <summary>
        /// El método verifica que se pudo conectar a la base de datos.
        /// </summary>
        /// <returns>Retorna true en caso de que se pueda conectar o false caso contario.</returns>
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
        

        /// <summary>
        /// El método se conecta a la base de datos y obtiene una lista de la tabla de jugadores.
        /// </summary>
        /// <returns>Retorna la lista obtenida.</returns>
        public List<Jugador> ObtenerListaDatoJugadores()
        {
            List<Jugador> lista = new List<Jugador>();
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Jugadores_generala";
                this.comando.Connection = this.conexion;
                this.conexion.Open();
                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Jugador jugador = new Jugador();
                    jugador.Id = (int)lector["ID"];
                    jugador.Nombre = lector["Nombre"].ToString() ?? "";
                    jugador.Puntaje = (int)lector["Puntaje"];
                    jugador.Victorias = (int)lector["Victorias"];
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

        /// <summary>
        /// El método agrega un jugador a la base de datos.
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public bool AgregarDatoJugador(Jugador jugador)
        {
            bool rta = true;
            try
            {
                string sql = "INSERT INTO Jugadores_generala (Nombre, Puntaje, Victorias) VALUES(";
                sql = sql + "'" + jugador.Nombre.ToString() + "'," + jugador.Puntaje + "," + jugador.Victorias + ")";

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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


        /// <summary>
        /// El método genera una consulta de tipo modificación a la base de datos de un jugador pasado por parametro.
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns>Retorna true en caso de exito o false caso contrario.</returns>
        public bool ModificarJugador(Jugador jugador)
        {
            bool rta = true;
            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@ID", jugador.Id);
                this.comando.Parameters.AddWithValue("@Nombre", jugador.Nombre);
                this.comando.Parameters.AddWithValue("@Puntaje", jugador.Puntaje);
                this.comando.Parameters.AddWithValue("@Victorias", jugador.Victorias);

                string sql = "UPDATE Jugadores_generala ";
                sql += "SET Nombre = @Nombre, Puntaje = @Puntaje, Victorias = @Victorias WHERE ID = @ID";

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
