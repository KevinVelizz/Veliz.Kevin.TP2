using Entidades;

namespace Aplicacion02
{
    public partial class FrmEstadistica : Form
    {
        private List<Jugador> jugadores;
        private List<SalaJuego> salas;
        public FrmEstadistica()
        {
            InitializeComponent();
            this.jugadores = new List<Jugador>();
            this.salas = new List<SalaJuego>();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmEstadistica_Load(object sender, EventArgs e)
        {
            this.jugadores = Soporte.ObtenerValoresJugadores();
            if (this.jugadores.Count > 0)
            {
                List<Jugador> listaOrdenadaDescendente = this.jugadores.OrderByDescending(jugador => jugador.Puntaje).ToList();
                this.dtgvJugadores.DataSource = listaOrdenadaDescendente;
            }
            this.salas = Soporte.ArchivoJson.Deserealizar(Soporte.ArchivoJson.PathSalas);

            if (this.salas.Count > 0)
            {
                foreach (SalaJuego salaJuego in this.salas)
                {
                    int rows = dtgvSalas.Rows.Add();
                    dtgvSalas.Rows[rows].Cells[0].Value = salaJuego.Jugador1.Nombre;
                    dtgvSalas.Rows[rows].Cells[1].Value = salaJuego.Jugador2.Nombre;
                    dtgvSalas.Rows[rows].Cells[2].Value = salaJuego.Jugador1.Puntaje;
                    dtgvSalas.Rows[rows].Cells[3].Value = salaJuego.Jugador2.Puntaje;
                    dtgvSalas.Rows[rows].Cells[4].Value = salaJuego.NombreJugadorGanador;
                    dtgvSalas.Rows[rows].Cells[5].Value = salaJuego.Turno;
                }
            }
        }
    }
}
