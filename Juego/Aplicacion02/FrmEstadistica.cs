using Entidades;

namespace Aplicacion02
{
    public partial class FrmEstadistica : Form
    {
        private AccesoDatos accesoDatos;
        private List<Jugador> jugadores;
        private List<SalaJuego> salas;
        public FrmEstadistica()
        {
            InitializeComponent();
            this.accesoDatos = new AccesoDatos();
            this.jugadores = new List<Jugador>();
            this.salas = new List<SalaJuego>();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnTraerJugadores_Click(object sender, EventArgs e)
        {
            this.jugadores = accesoDatos.ObtenerListaDatoJugadores();
            if (this.jugadores.Count > 0)
            {
                this.dtgvJugadores.DataSource = this.jugadores;
            }
            this.salas = Archivos.DeserealizarSalas();
            this.dtgvSalas.DataSource = this.salas;
        }

        private void FrmEstadistica_Load(object sender, EventArgs e)
        {

        }
    }
}
