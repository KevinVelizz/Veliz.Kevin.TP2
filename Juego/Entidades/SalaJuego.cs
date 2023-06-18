namespace Entidades
{
    public class SalaJuego
    {
        private bool jugando = true;
        private int turnosCompletados = 0;
        private static int contadorSalas = 0;
        private int id;
        private Jugador jugador1;
        private Jugador jugador2;

        public event EventHandler SalaTerminada;

        public SalaJuego(string nombreJugador1, string nombreJugador2)
        {
            this.id = ++contadorSalas;
            this.jugador1 = new Jugador(nombreJugador1);
            this.jugador2 = new Jugador(nombreJugador2);
        }

        public int Id
        {
            get { return this.id; }
            private set { this.id = value; }
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

        public void Jugar()
        {
            while (this.jugando)
            { 
                jugador1.LanzarDados();


                jugador2.LanzarDados();

                this.turnosCompletados = jugador1.Turnos + jugador2.Turnos;
           
                if (TerminarSala())
                {
                    Terminar();
                }
            }
        }

        public void Terminar()
        {
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
            if (turnosCompletados >= 6)
            {
                return true;
            }
            return false;
        }
    }
}
