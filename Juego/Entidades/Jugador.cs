
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

        //public int ElegirCategoria(List<int> listaCategorias)
        //{
        //    if (listaCategorias.Count > 0)
        //    {
        //        try
        //        {
        //            List<int> nuevaLista = listaCategorias.Except(this.categorias).ToList();
        //            try
        //            {
        //                if (nuevaLista.Count > 0)
        //                {
        //                    int random = new Random().Next(0, nuevaLista.Count);
        //                    int puntaje = nuevaLista[random];
        //                    this.categorias.Add(puntaje);
        //                    this.puntaje += puntaje;
        //                    return puntaje;
        //                }
        //            }
        //            catch (ArgumentOutOfRangeException e)
        //            {
        //                Console.WriteLine($"{e.Message} - {e.StackTrace}");
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine($"{e.Message} - {e.StackTrace}");
        //        }
        //    }
        //    return 0;
        //}
        public void CalcularPuntos(int puntos)
        {
            this.puntaje += puntos;
        }

        public List<int> LanzarDados()
        {
            List<int> dados = Funcionalidades.EstablecerValor(5);
            Thread.Sleep(2000);
            this.ActualizarDados?.Invoke(dados);
            
            this.turnos += 1;

            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(2000);
                if (Funcionalidades.ObtenerBooleanoAleatorio())
                {
                    dados = Funcionalidades.VolverATirar(dados);
                    this.ActualizarDados?.Invoke(dados);
                    this.turnos += 1;
                }
            }
            int puntosCaegoria = Categorias.CalculaTipoCategoria(dados);
            this.CalcularPuntos(puntosCaegoria);
            Console.WriteLine($"Terminó jugador {this.nombre}");
            Thread.Sleep(2000);
            return dados;
        }
    }
}