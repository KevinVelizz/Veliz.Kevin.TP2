namespace Entidades
{
    public static class Categorias
    {
        public static List<int> CalculaTipoCategoria(List<int> dados)
        {
            List<int> listaCategorias = new List<int>();
            for (int i = 0; i < dados.Count; i++)
            {
                if (dados[i] == 1)
                {
                    listaCategorias.Add(200);
                }
                else if (dados[i] == 2)
                {
                    listaCategorias.Add(50);
                }
                else if (dados[i] == 3)
                {
                    listaCategorias.Add(100);
                }
                else if (dados[i] == 4)
                {
                    listaCategorias.Add(150);
                }
            }
            return listaCategorias;
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
                    if (primerDado == dados[i])
                    {
                        contador++;
                    }
                }
                if (contador == 5)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool EsPoker(List<int> dados)
        {
            bool retorno = false;
            int j = 0;
            int contador = 0;
            
            for (int i = 0; i < 2; i++)
            {
                j = i;
                while (j < 5)
                {
                    if (i != j && dados[i] == dados[j])
                    {
                        contador++;   
                    }
                    j++;
                }
            } 
            if (contador == 3)
            {
                retorno = true;
            }
            
            return retorno;
        }
    }
}
