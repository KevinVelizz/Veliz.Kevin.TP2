namespace Entidades
{
    public class Categorias
    {
        public static List<int> CalculaTipoCategoria(List<int> dados, bool unicoTiro)
        {
            List<int> listaPuntosCategorias = new List<int>();
            for (int i = 0; i < dados.Count; i++)
            {
                if (EsGenerala(dados))
                {
                    if (unicoTiro)
                    {
                        listaPuntosCategorias.Add(100);
                    }
                    else
                    {
                        listaPuntosCategorias.Add(50);
                    }
                }
                else if (EsGeneralaReal(dados))
                {
                    listaPuntosCategorias.Add(60);
                }
                else if (EsEscaleraMayor(dados) || EsEscaleraMenor(dados))
                {
                    listaPuntosCategorias.Add(20);
                }
                else if (EsPoker(dados))
                {
                    listaPuntosCategorias.Add(40);
                }
                else if (EsFull(dados))
                {
                    listaPuntosCategorias.Add(30);
                }
                else
                {
                    listaPuntosCategorias.Add(0);
                }
            }
            return listaPuntosCategorias;
        }

        public static bool EsGenerala(List<int> dados)
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
        public static bool EsPoker(List<int> dados)
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

        public static bool EsFull(List<int> dados)
        {
            bool retorno = false;
            dados.Sort();
            if (dados[0] == dados[1] && dados[1] == dados[2] && dados[3] == dados[4] || dados[0] == dados[1] && dados[2] == dados[3] && dados[3] == dados[4])
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool EsEscaleraMenor(List<int> dados)
        {
            dados.Sort();
            bool retorno = false;
            for (int i = 0; i < dados.Count - 1; i++)
            {
                if (dados[i] == dados[i + 1] && dados[0] == 1) 
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

        public static bool EsEscaleraMayor(List<int> dados)
        {
            dados.Sort();
            bool retorno = false;
            for (int i = 0; i < dados.Count - 1; i++)
            {
                if (dados[i] == dados[i + 1] && dados[0] == 2)
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

        public static bool EsGeneralaReal(List<int> dados)
        {
            bool retorno = false;
            if (dados[0] == 1 && dados[0] == dados[1] && dados[0] == dados[2] && dados[0] == dados[3] && dados[0] == dados[4])
            {
                retorno = true;
            }
            return retorno;
        }

        
    }
}
