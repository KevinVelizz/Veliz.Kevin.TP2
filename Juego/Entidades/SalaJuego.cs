namespace Entidades
{
    public class SalaJuego
    {
        private bool jugando = true;
        private static int contadorSalas = 0;
        private int id;
        private Jugador jugador1;
        private Jugador jugador2;

        public event EventHandler SalaTerminada;
        public event ActualizarCategoriasEventHandler ActualizarCategorias;

        public SalaJuego(string nombreJugador1, string nombreJugador2)
        {
            this.id = ++contadorSalas;
            this.jugador1 = new Jugador(nombreJugador1);
            this.jugador2 = new Jugador(nombreJugador2);
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
        public void Jugar(CancellationTokenSource cancellationTokenSource)
        {
            while(this.jugando && !cancellationTokenSource.IsCancellationRequested)
            {
                this.jugador1.LanzarDados();
                this.OnActualizarCategorias(this.jugador1);

                this.jugador2.LanzarDados();
                this.OnActualizarCategorias(this.jugador2);

                if (TerminarSala())
                {
                    this.Terminar();
                }
            } 
            this.Terminar();
        }

        public void Terminar()
        {
            if (this.jugador1.Puntaje > this.jugador2.Puntaje)
            {
                this.jugador1.Victorias += 1;
                Console.WriteLine($"El ganador es:{this.jugador1.Nombre}");
            }
            else
            {
                this.jugador2.Victorias += 1;
                Console.WriteLine($"El ganador es: {this.jugador2.Nombre}");
            }
            this.jugando = false;
            OnSalaTerminada(); 
            Console.WriteLine("Sala de juego terminada: " + Id);
        }

        private void OnSalaTerminada()
        {
            SalaTerminada?.Invoke(this, EventArgs.Empty);
        }

        private bool TerminarSala()
        {
            if (jugador1.categorias.TerminoJuego || jugador2.categorias.TerminoJuego || jugador2.Turnos == 5)
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
