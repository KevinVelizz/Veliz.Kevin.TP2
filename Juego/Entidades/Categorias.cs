using System.Collections.Generic;

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
        private Dictionary<int, bool> categoriaRealizada;


        public Categorias()
        {
            this.categoriaRealizada = new Dictionary<int, bool>();
            for (int i = 1; i <= 6; i++)
            {
                this.categoriaRealizada.Add(i, false);
            }
        }

        public int CalculaTipoCategoria(List<int> dados)
        {
            int puntos = 0;

            

            if (EsGenerala(dados) && !this.esGenerala)
            {
                puntos = 100;
                this.esGenerala = !this.esGenerala;
            }
            else if (EsGeneralaReal(dados) && !this.esGeneralaReal)
            {
                puntos = 60;
                this.esGeneralaReal = !this.esGeneralaReal;
            }
            else if (EsEscaleraMenor(dados) && !this.esEscaleraMenor)
            {
                puntos = 20;
                this.esEscaleraMenor = !this.esEscaleraMenor;
            }
            else if (EsEscaleraMayor(dados) && !this.esEscaleraMayor)
            {
                puntos = 20;
                this.esEscaleraMayor = !this.esEscaleraMayor;
            }
            else if (EsPoker(dados) && !this.esPoker)
            {
                puntos = 40;
                this.esPoker = !this.esPoker;
            }
            else if (EsFull(dados) && !this.esFull)
            {
                puntos = 30;
                this.esFull = !this.esFull;
            }
            else
            {
                puntos = this.DevolverPuntajeNumeros(dados);
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
                    return true;
                }
            }
            return false;
        }

        public bool EsFull(List<int> dados)
        {
            bool retorno = false;
            dados.Sort();
            if (dados[0] == dados[1] && dados[1] == dados[2] && dados[3] == dados[4] || dados[0] == dados[1] && dados[2] == dados[3] && dados[3] == dados[4])
            {
                retorno = true;
            }
            return retorno;
        }

        public bool EsEscaleraMenor(List<int> dados)
        {
            dados.Sort();
            bool retorno = false;
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
            return retorno;
        }

        public bool EsEscaleraMayor(List<int> dados)
        {
            dados.Sort();
            bool retorno = false;
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
            return retorno;
        }

        public bool EsGeneralaReal(List<int> dados)
        {
            bool retorno = false;
            if (dados[0] == 1 && dados[0] == dados[1] && dados[0] == dados[2] && dados[0] == dados[3] && dados[0] == dados[4])
            {
                retorno = true;
            }
            return retorno;
        }

        public int DevolverPuntajeNumeros(List<int> dados)
        {
            Dictionary<int, int> dadosRepetidos = new Dictionary<int, int>();

            for (int i = 0; i < dados.Count; i++)
            {
                for (int j = i + 1; j < dados.Count; j++)
                {
                    if (dados[i] == dados[j])
                    {
                        if (!dadosRepetidos.ContainsKey(dados[j]))
                        {
                            dadosRepetidos.Add(dados[i], 1);
                        }
                        dadosRepetidos[dados[i]] += 1;
                    }
                }
            }
            Dictionary<int, int> dadosOrdenados = dadosRepetidos.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            KeyValuePair<int, int> primerElemento = dadosOrdenados.FirstOrDefault();
            if (this.categoriaRealizada[primerElemento.Key])
            {
                //Acceder a 2do que mas veces repitio si es que tiene. Si no tiene devuelve el uno si es que no se realizó la jugada.
            }
            return primerElemento.Key * primerElemento.Value;
        }
    }
}
