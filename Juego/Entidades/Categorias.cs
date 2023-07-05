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

        /// <summary>
        /// El método verifica que jugada se produjo, agregar esa jugada al diccionario de las categorias realizadas y retorna los puntos realizados.
        /// </summary>
        /// <param name="dados"></param>
        /// <returns>Retorna los puntos generados dependiendo la jugada.</returns>
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


        /// <summary>
        /// El método verifica si los dados pertenece a la jugada generala es decir que todos los dados sean igual excepto todos uno.
        /// </summary>
        /// <param name="dados"></param>
        /// <returns>Retorna true en caso de ser la jugada esperada o false caso contrario.</returns>
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


        /// <summary>
        /// El método verifica si los dados pertenece a la jugada poker es decir que contenga 4 dados iguales.
        /// </summary>
        /// <param name="dados"></param>
        /// <returns>Retorna true en caso de ser la jugada esperada o false caso contrario.</returns>
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
                        break;
                    }
                }
            }
            return retorno;
        }


        /// <summary>
        /// El método verifica si los dados pertenece a la jugada es full es decir que contenga 3 dados iguales y 2 dados iguales diferentes a los anteriores.
        /// </summary>
        /// <param name="dados"></param>
        /// <returns>Retorna true en caso de ser la jugada esperada o false caso contrario.</returns>
        public bool EsFull(List<int> dados)
        {
            bool retorno = false;
            if (dados.Count > 0)
            {
                dados.Sort();
                if ((dados[0] == dados[1] && dados[1] == dados[2] && dados[3] == dados[4] || dados[0] == dados[1] && dados[2] == dados[3] && dados[3] == dados[4]) && (dados[0] != dados[4]))
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// El método verifica si los dados pertenece a la jugada Escalera Menor es decir que contenga la lista de dados los valores 1 al 5.
        /// </summary>
        /// <param name="dados"></param>
        /// <returns>Retorna true en caso de ser la jugada esperada o false caso contrario.</returns>
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


        /// <summary>
        /// El método verifica si los dados pertenece a la jugada Escalera mayor es decir que contenga la lista de dados los valores 2 al 6.
        /// </summary>
        /// <param name="dados"></param>
        /// <returns>Retorna true en caso de ser la jugada esperada o false caso contrario.</returns>
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


        /// <summary>
        /// El método verifica si los dados pertenece a la jugada generala real es decir que todos los dados sean igual 1.
        /// </summary>
        /// <param name="dados"></param>
        /// <returns>Retorna true en caso de ser la jugada esperada o false caso contrario.</returns>
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


        /// <summary>
        /// El método verifica si los dados pertenece a la jugada númerica, es decir, si no genera ninguna jugada anterior elegirá
        /// la key con mayor repetición.
        /// </summary>
        /// <param name="dados"></param>
        /// <returns>Retorna el valor del puntaje que es la multiplicación del valor del dado por la cantidad de veces que salió.</returns>
        public int DevolverPuntajeNumeros(List<int> dados)
        {
            Dictionary<int, int> dadosRepetidos = new Dictionary<int, int>();

            if (dados.Count > 0)
            {
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

                while (dadosOrdenados.Count > 0 && (this.categoriaRealizada.ContainsKey(primerElemento.Key.ToString()) && this.categoriaRealizada[primerElemento.Key.ToString()]))
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


        /// <summary>
        /// El método verifica si hay jugadas númericas y retorna true o false.
        /// </summary>
        /// <returns>Retorna true en caso de haber jugadas o false caso contrario.</returns>
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

        /// <summary>
        /// El método verifica si hizo alguna jugada especial para que en caso de la 1ra 0 2da tirada haya hecho alguna jugada especial conserve esa jugada y pase el turno.
        /// </summary>
        /// <param name="dados"></param>
        /// <returns>Retorna true en caso de generar una jugada especial o false caso contrario.</returns>
        public bool EsCategoriaEspecial(List<int> dados)
        {
            return this.EsGeneralaReal(dados) || this.EsGenerala(dados) || this.EsEscaleraMayor(dados) || this.EsEscaleraMenor(dados) || this.EsPoker(dados) || this.EsFull(dados);
        }
    }
}
