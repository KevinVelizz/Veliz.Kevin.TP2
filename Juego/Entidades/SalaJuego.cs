namespace Entidades
{
    public class SalaJuego
    {
        private bool jugando = true;
        private static int contadorJugadores = 0;
        private int id;
        private Jugador jugador1;
        private Jugador jugador2;
        private string nombreJugadorGanador;

        public event EventHandler SalaTerminada;
        public event ActualizarCategoriasEventHandler ActualizarCategorias;

        public SalaJuego()
        {

        }

        public SalaJuego(Jugador jugador1, Jugador jugador2)
        {
            this.id = ++contadorJugadores;
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public Jugador Jugador1
        {
            get { return this.jugador1; }
            set { this.jugador1 = value; }
        }

        public Jugador Jugador2
        {
            get { return this.jugador2; }
            set { this.jugador2 = value; }
        }

        public string NombreJugadorGanador
        {
            get { return this.nombreJugadorGanador; }
            set { this.nombreJugadorGanador = value; }
        }
        public void Jugar(CancellationTokenSource cancellationTokenSource)
        {
            do
            {
                this.jugador1.LanzarDados();
                this.OnActualizarCategorias(this.jugador1);

                this.jugador2.LanzarDados();
                this.OnActualizarCategorias(this.jugador2);

                if (TerminarSala())
                {
                    this.Terminar();
                }
            } while (this.jugando && !cancellationTokenSource.IsCancellationRequested);

            if (cancellationTokenSource.IsCancellationRequested)
            {
                this.Terminar();
            }
        }

        public void Terminar()
        {
            if (this.jugador1.Puntaje > this.jugador2.Puntaje)
            {
                this.nombreJugadorGanador = this.jugador1.Nombre;
                Console.WriteLine($"El ganador es:{this.jugador1.Nombre}");
            }
            else
            {
                this.nombreJugadorGanador = this.jugador2.Nombre;
                Console.WriteLine($"El ganador es: {this.jugador2.Nombre}");
            }
            this.jugando = false;
            OnSalaTerminada(); 
            Console.WriteLine("Sala de juego terminada: " + Id);
        }

        private void OnSalaTerminada()
        {
            if (SalaTerminada is not null)
            {
                SalaTerminada?.Invoke(this, EventArgs.Empty);
            }
        }

        private bool TerminarSala()
        {
            if (jugador1.categorias.TerminoJuego || jugador2.categorias.TerminoJuego || jugador2.Turnos == 7)
            {
                return true;
            }
            return false;
        }

        private void OnActualizarCategorias(Jugador jugador)
        {
            if (this.ActualizarCategorias is not null)
            {
                this.ActualizarCategorias?.Invoke(jugador);
            }
        }
    }
}
