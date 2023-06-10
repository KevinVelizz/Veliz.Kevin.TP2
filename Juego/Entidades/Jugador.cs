using System;

namespace Entidades
{
    public class Jugador
    {
        private string nombre;
        private int tiradas;
        private int puntaje;
        private List<int> categorias;

        private Jugador() 
        {
            this.categorias = new List<int>();
            this.tiradas = 3;
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

        private int Tiradas
        {
            get { return this.tiradas; }
            set { this.tiradas = value; }
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
    }
}