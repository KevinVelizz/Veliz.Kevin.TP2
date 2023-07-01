

using System.Xml.Serialization;

namespace Entidades
{
    public class Categorias
    {
        private bool esGenerala;
        private bool esPoker;
        private bool esEscaleraMayor;
        private bool esGeneralaReal;
        private bool esEscaleraMenor;
        private bool esFull;
        private bool terminoJuego;
        private Dictionary<string, bool> categoriaRealizada;

        public Categorias()
        {
            this.categoriaRealizada = new Dictionary<string, bool>();
            for (int i = 1; i <= 6; i++)
            {
                this.categoriaRealizada.Add($"{i}", false);
            }
        }

        [XmlIgnore]
        public Dictionary<string, bool> CategoriaRealizada
        {
            get { return this.categoriaRealizada; }
            set { this.categoriaRealizada = value; }
        }

        public bool TerminoJuego { get => terminoJuego;}

        public int CalculaTipoCategoria(List<int> dados)
        {
            int puntos = 0;
            if (EsGenerala(dados) && !this.esGenerala)
            {
                puntos = 100;
                this.esGenerala = !this.esGenerala;
                this.categoriaRealizada.Add("Es generala", true);
            }
            else if (EsGeneralaReal(dados) && !this.esGeneralaReal)
            {
                puntos = 60;
                this.esGeneralaReal = !this.esGeneralaReal;
                this.categoriaRealizada.Add("Es GeneralaReal", true);
            }
            else if (EsEscaleraMenor(dados) && !this.esEscaleraMenor)
            {
                puntos = 20;
                this.esEscaleraMenor = !this.esEscaleraMenor;
                this.categoriaRealizada.Add("Es EscaleraMenor", true);
            }
            else if (EsEscaleraMayor(dados) && !this.esEscaleraMayor)
            {
                puntos = 20;
                this.esEscaleraMayor = !this.esEscaleraMayor;
                this.categoriaRealizada.Add("Es EscaleraMayor", true);
            }
            else if (EsPoker(dados) && !this.esPoker)
            {
                puntos = 40;
                this.esPoker = !this.esPoker;
                this.categoriaRealizada.Add("Es Poker", true);
            }
            else if (EsFull(dados) && !this.esFull)
            {
                puntos = 30;
                this.esFull = !this.esFull;
                this.categoriaRealizada.Add("Es Full", true);
            }
            else if (this.QuedanCategoriasNumericas())
            {
                puntos = this.DevolverPuntajeNumeros(dados);
            }

            if (this.esEscaleraMayor && this.esEscaleraMenor && this.esPoker && this.esGenerala && this.esFull && this.esGeneralaReal && !this.QuedanCategoriasNumericas())
            {
                this.terminoJuego = true;
            }
            return puntos;
        }

        public bool EsGenerala(List<int> dados)
        {
            bool retorno = false;
            if (dados.Count > 0)
            {
                int primerDado = dados[0];
                int contador = 0;
                for (int i = 1;  i < dados.Count; i++)
                {
                    if (primerDado == dados[i] && dados[0] != 1)
                    {
                        contador++;
                    }
                }
                if (contador == 4)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public bool EsPoker(List<int> dados)
        {
            bool retorno = false;
            if (dados.Count > 0)
            {
                foreach (int dado in dados)
                {
                    int contador = 0;
                    foreach (int otroDado in dados)
                    {
                        if (dado == otroDado)
                        {
                            contador++;
                        }
                    }
                    if (contador == 4)
                    {
                        retorno = true;
                    }
                }
            }
            
            return retorno;
        }

        public bool EsFull(List<int> dados)
        {
            bool retorno = false;
            try
            {
                dados.Sort();
                if (dados[0] == dados[1] && dados[1] == dados[2] && dados[3] == dados[4] || dados[0] == dados[1] && dados[2] == dados[3] && dados[3] == dados[4])
                {
                    retorno = true;
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"{e.StackTrace} - {e.Message}");
            }
            return retorno;
        }

        public bool EsEscaleraMenor(List<int> dados)
        {
            bool retorno = false;
            if (dados.Count > 0)
            {
                dados.Sort();
                for (int i = 0; i < dados.Count - 1; i++)
                {
                    if (dados[i] + 1 == dados[i + 1] && dados[0] == 1)
                    {
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;
                        break;
                    }
                }
            }
            return retorno;
        }

        public bool EsEscaleraMayor(List<int> dados)
        {
            bool retorno = false;
            if (dados.Count > 0)
            {
                dados.Sort();
                
                for (int i = 0; i < dados.Count - 1; i++)
                {
                    if (dados[i] + 1 == dados[i + 1] && dados[0] == 2)
                    {
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;
                        break;
                    }
                }
            }
            return retorno;
        }

        public bool EsGeneralaReal(List<int> dados)
        {
            bool retorno = false;
            if (dados.Count > 0)
            {
                
                if (dados[0] == 1 && dados[0] == dados[1] && dados[0] == dados[2] && dados[0] == dados[3] && dados[0] == dados[4])
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public int DevolverPuntajeNumeros(List<int> dados)
        {
            Dictionary<int, int> dadosRepetidos = new Dictionary<int, int>();

            for (int i = 0; i < dados.Count; i++)
            {
                if (!dadosRepetidos.ContainsKey(dados[i]))
                {
                    dadosRepetidos.Add(dados[i], 1);
                }
                else
                {
                    dadosRepetidos[dados[i]] += 1;
                }
            }
            Dictionary<int, int> dadosOrdenados = dadosRepetidos.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            KeyValuePair<int, int> primerElemento = dadosOrdenados.FirstOrDefault();
            if (!this.categoriaRealizada.ContainsKey("0"))
            {
                while (this.categoriaRealizada[primerElemento.Key.ToString()] && dadosOrdenados.Count > 0)
                {
                    dadosOrdenados.Remove(primerElemento.Key);
                    primerElemento = dadosOrdenados.FirstOrDefault();
                }

                if (dadosOrdenados.Count > 0)
                {
                    this.categoriaRealizada[primerElemento.Key.ToString()] = true;
                }
                return primerElemento.Key * primerElemento.Value;
            }
            return 0;
        }

        private bool QuedanCategoriasNumericas()
        {
            for (int i = 1; i <= 6; i++)
            { 
                if (!this.categoriaRealizada[i.ToString()])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
