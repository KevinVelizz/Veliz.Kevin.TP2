
using System.Text;

namespace Entidades
{
    public class Jugador : IJugador
    {
        private int id;
        private string nombre;
        private static int contadorJugadores = 0;
        private int puntaje;
        private int victorias;
        private int turnos;
        public Categorias categorias;

        private List<Dictionary<string, bool>> listaCategorias;
        public event ActualizarDadosEventHandler ActualizarDados;

        private Jugador() 
        {
            this.id = ++contadorJugadores;
            this.categorias = new Categorias();
            this.listaCategorias = new List<Dictionary<string, bool>>();
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
            set { this.victorias = value; }
        }

        public int Turnos
        {
            get { return this.turnos; }
            set { this.turnos = value; }
        }

        public List<Dictionary<string, bool>> ListaCategorias { get => listaCategorias; set => listaCategorias = value; }

        public void CalcularPuntos(int puntos)
        {
            this.puntaje += puntos;
        }

        public List<int> LanzarDados()
        {
            List<int> dados = Funcionalidades.EstablecerValor(5);
            Thread.Sleep(2000);
            this.OnActualizarDados(dados);
            

            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(2000);
                if (Funcionalidades.ObtenerBooleanoAleatorio())
                {
                    dados = Funcionalidades.VolverATirar(dados);
                    this.OnActualizarDados(dados);
                }
            }
            int puntosCategoria = categorias.CalculaTipoCategoria(dados);
            this.CalcularPuntos(puntosCategoria);
            this.ListaCategorias.Add(categorias.CategoriaRealizada);
            this.turnos += 1;
            Console.WriteLine($"Terminó jugador {this.nombre}");
            Thread.Sleep(2000);
            return dados;
        }

        private void OnActualizarDados(List<int> dados)
        {
            this.ActualizarDados?.Invoke(dados);
        }

        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.id}");
            sb.AppendLine($"{this.nombre}");
            sb.AppendLine($"{this.puntaje}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}