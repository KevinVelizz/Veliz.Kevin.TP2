
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    public class Jugador
    {
        private int id;
        private string nombre;
        private int puntaje;
        private int victorias;
        private int turnos;
        public Categorias categorias;

        private List<Dictionary<string, bool>> listaCategorias;
        public event ActualizarDadosEventHandler ActualizarDados;

        public Jugador() 
        {
            this.categorias = new Categorias();
            this.listaCategorias = new List<Dictionary<string, bool>>();
            this.puntaje = 0;
            this.victorias = 0;
        }
        
        public Jugador(string nombre) :this()
        {
            if (this.CompararNombre(nombre))
            {
                throw new Exception("Ya existe un jugador con ese nombre.");
            }
            else
            {
                this.nombre = ValidarCampo(nombre);
            }
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

        [XmlIgnore]
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
            if (!this.listaCategorias.Contains(categorias.CategoriaRealizada))
            {
                this.ListaCategorias.Add(categorias.CategoriaRealizada);
            }
            
            this.turnos += 1;
            Console.WriteLine($"Terminó jugador {this.nombre}");
            Thread.Sleep(2000);
            return dados;
        }

        private bool CompararNombre(string nombre)
        {
            bool retorno = false;
            foreach (Jugador jugador in Soporte.ObtenerValoresJugadores())
            {
                if (jugador.Nombre == nombre)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        private string ValidarCampo(string campo)
        {
            string campoValidado = "";
            if (string.IsNullOrEmpty(campo))
            {
                throw new Exception("Completar el campo.");
            }
            campoValidado = campo;
            return campoValidado;
        }

        private void OnActualizarDados(List<int> dados)
        {
            this.ActualizarDados?.Invoke(dados);
        }

        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}