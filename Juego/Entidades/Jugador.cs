
namespace Entidades
{
    public class Jugador : IJugador
    {
        private int id;
        private string nombre;
        private int puntaje;
        private int victorias;
        private int turnos;

        public event ActualizarDadosEventHandler ActualizarDados;

        private Jugador() 
        {
            
        }
        
        public Jugador(string nombre) :this()
        {
            this.nombre = nombre;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int Puntaje
        {
            get { return this.puntaje; }
            set { this.puntaje = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Victorias
        {
            get { return this.victorias; }
            private set { this.victorias = value; }
        }

        public int Turnos
        {
            get { return this.turnos; }
            private set { this.turnos = value; }
        }

        public void CalcularPuntos(int puntos)
        {
            this.puntaje += puntos;
        }

        public List<int> LanzarDados()
        {
            List<int> dados = Funcionalidades.EstablecerValor(5);
            Thread.Sleep(2000);
            this.OnActualizarDados(dados);
            this.turnos += 1;
            Categorias categorias = new Categorias();

            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(2000);
                if (Funcionalidades.ObtenerBooleanoAleatorio())
                {
                    dados = Funcionalidades.VolverATirar(dados);
                    this.OnActualizarDados(dados);
                    this.turnos += 1;
                }
            }
            int puntosCaegoria = categorias.CalculaTipoCategoria(dados);
            this.CalcularPuntos(puntosCaegoria);
            Console.WriteLine($"Terminó jugador {this.nombre}");
            Thread.Sleep(2000);
            return dados;
        }

        private void OnActualizarDados(List<int> dados)
        {
            this.ActualizarDados?.Invoke(dados);
        }
    }
}