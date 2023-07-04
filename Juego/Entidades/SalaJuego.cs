namespace Entidades
{
    public class SalaJuego
    {
        private bool jugando = true;
        private static int contadorSala = 0;
        private int id;
        private Jugador jugador1;
        private Jugador jugador2;
        private string nombreJugadorGanador;
        private int turno;
        private string jugadorJugando;
        private int puntosJugador1;
        private int puntosJugador2;

        public event EventHandler SalaTerminada;
        public event ActualizarCategoriasEventHandler ActualizarCategorias;

        public SalaJuego(){}

        public SalaJuego(Jugador jugador1, Jugador jugador2)
        {
            this.id = ++contadorSala;
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
            this.puntosJugador1 = jugador1.Puntaje;
            this.puntosJugador2 = jugador2.Puntaje;
            this.jugador1.Puntaje = 0;
            this.jugador2.Puntaje = 0;
            this.jugador1.Turnos = 0;
            this.jugador2.Turnos = 0;
            this.turno = 0;
            this.jugadorJugando = jugador1.Nombre;
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

        public int Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }
        
        public string JugadorJugando
        {
            get { return this.jugadorJugando; }
            set { this.jugadorJugando = value; }
        }
        
        public int PuntosJugador1 { get => puntosJugador1; set => puntosJugador1 = value; }
        
        public int PuntosJugador2 { get => puntosJugador2; set => puntosJugador2 = value; }


        /// <summary>
        /// El método inicia el juego.
        /// </summary>
        /// <param name="cancellationTokenSource"></param>
        public void Jugar(CancellationTokenSource cancellationTokenSource)
        {
            while (this.jugando && !cancellationTokenSource.IsCancellationRequested)
            {
                this.jugadorJugando = this.jugador1.Nombre;
                this.turno++;
                this.jugador1.LanzarDados();
                this.OnActualizarCategorias(this.jugador1);

                this.jugadorJugando = this.jugador2.Nombre;
                this.jugador2.LanzarDados();
                this.OnActualizarCategorias(this.jugador2);

                if (TerminarSala())
                {
                    this.Terminar();
                }
            }

            if (cancellationTokenSource.IsCancellationRequested)
            {
                this.Terminar();
            }
        }


        /// <summary>
        /// El método se ejecuta cuando se termina el juego y se muestra el ganador.
        /// </summary>
        public void Terminar()
        {
            if (this.jugador1.Puntaje > this.jugador2.Puntaje)
            {
                this.nombreJugadorGanador = this.jugador1.Nombre;
                this.jugador1.Victorias += 1;
                Console.WriteLine($"El ganador es:{this.jugador1.Nombre}");
            }
            else if (this.jugador2.Puntaje > this.jugador1.Puntaje)
            {
                this.nombreJugadorGanador = this.jugador2.Nombre;
                this.jugador2.Victorias += 1;
                Console.WriteLine($"El ganador es: {this.jugador2.Nombre}");
            }
            else
            {
                this.nombreJugadorGanador = "Empate.";
                Console.WriteLine($"Empate.");
            }
            this.jugando = false;
            OnSalaTerminada(); 
            Console.WriteLine("Sala de juego terminada: " + Id);
        }


        /// <summary>
        /// El método genera la invocación del evento SalaTerminada.
        /// </summary>
        private void OnSalaTerminada()
        {
            if (SalaTerminada is not null)
            {
                SalaTerminada?.Invoke(this, EventArgs.Empty);
            }
        }


        /// <summary>
        /// El método consulta si el juego terminó o no.
        /// </summary>
        /// <returns>Retorna un bool en caso de exito o fracaso caso contrario.</returns>
        private bool TerminarSala()
        {
            return jugador1.categorias.TerminoJuego || jugador2.categorias.TerminoJuego || jugador2.Turnos == 4;
        }


        /// <summary>
        /// El método genera la invocación del evento ActualizarCategorias.
        /// </summary>
        /// <param name="jugador"></param>
        private void OnActualizarCategorias(Jugador jugador)
        {
            if (this.ActualizarCategorias is not null)
            {
                this.ActualizarCategorias?.Invoke(jugador);
            }
        }
    }
}
