
namespace Entidades
{
    public class Jugador : IJugador
    {
        private string nombre;
        private int puntaje;
        private List<int> categorias;
        private int victorias;

        private Jugador() 
        {
            this.categorias = new List<int>();
        }
        
        public Jugador(string nombre) :this()
        {
            this.nombre = nombre;
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

        public int ElegirCategoria(List<int> listaCategorias)
        {
            if (listaCategorias.Count > 0)
            {
                try
                {
                    List<int> nuevaLista = listaCategorias.Except(this.categorias).ToList();
                    try
                    {
                        if (nuevaLista.Count > 0)
                        {
                            int random = new Random().Next(0, nuevaLista.Count);
                            int puntaje = nuevaLista[random];
                            this.categorias.Add(puntaje);
                            this.puntaje += puntaje;
                            return puntaje;
                        }
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine($"{e.Message} - {e.StackTrace}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message} - {e.StackTrace}");
                }
            }
            return 0;
        }
        public void CalcularPuntos(List<int> listaPuntos)
        {
            foreach (int puntos in listaPuntos)
            {
                this.puntaje += puntos;
            }
        }

        public List<int> LanzarDados()
        {
            List<int> dados = Funcionalidades.EstablecerValor(5);
            for (int i = 0; i < 2; i++)
            {
                if (Funcionalidades.ObtenerBooleanoAleatorio())
                {
                    Funcionalidades.VolverATirar(dados);
                }
            }
            return dados;
        }
    }
}