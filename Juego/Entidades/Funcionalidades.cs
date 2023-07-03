namespace Entidades
{
    public static class Funcionalidades
    {
        /// <summary>
        /// El método establece un valor aleatorio entre 1 y 6 para determinar el valor de los dados.
        /// </summary>
        /// <param name="cantidadDadosTirar"></param>
        /// <returns>Retorna la lista de los dados.</returns>
        public static List<int> EstablecerValor(int cantidadDadosTirar)
        {
            List<int> dados = new List<int>();
            for (int i = 0; i < cantidadDadosTirar; i++)
            {
                int numRandom = new Random().Next(1, 7);
                dados.Add(numRandom);
            }
            return dados;
        }

        /// <summary>
        /// El metódo establece un valor aleatorio del 1 al 5 para saber la cant. de dados que quiere volver a tirar.
        /// </summary>
        /// <returns>Retorna un entero con la cant. de dados.</returns>
        public static int DevolverCantidadDadosATirar()
        {
            return new Random().Next(1, 6);
        }

        /// <summary>
        /// El metódo establece un valor aleatorio del 0 al 4 para determinar el indice del dado que quiere volver a tirar.
        /// </summary>
        /// <param name="cantidad"></param>
        /// <returns>Retorna una lista con los indices de los dados.</returns>
        public static List<int> DevolverIndicesDados(int cantidad)
        {
            List<int> indicesDeLosDados = new List<int>();
            for (int i = 0; i < cantidad; i++)
            {
                int random = new Random().Next(0, 5);
                while (indicesDeLosDados.Contains(random))
                {
                    random = new Random().Next(0, 5);
                }
                indicesDeLosDados.Add(random);
            }
            return indicesDeLosDados;
        }

        /// <summary>
        /// El método establece un numero aleatorio entre 0 y 1, en caso de ser 0 es true y 1 false.
        /// </summary>
        /// <returns>Retorna un bool.</returns>
        public static bool ObtenerBooleanoAleatorio()
        {
            return new Random().Next(2) == 0;
        }

        /// <summary>
        /// El método modifica la lista en caso de que haya vuelto a tirar con los nuevos valores de los dados.
        /// </summary>
        /// <param name="dados"></param>
        /// <returns>Retorna la lista con los nuevos dados.</returns>
        public static List<int> VolverATirar(List<int> dados)
        {
            int cantidaDadosAVolverATirar = DevolverCantidadDadosATirar();
            List<int> indicesDadosASacar = DevolverIndicesDados(cantidaDadosAVolverATirar);
            indicesDadosASacar.Sort((x, y) => y.CompareTo(x));

            if (dados.Count > 0)
            {
                foreach (int dado in indicesDadosASacar)
                {
                    dados.Remove(dados[dado]);
                }
                List<int> nuevosDados = EstablecerValor(cantidaDadosAVolverATirar);
                dados.AddRange(nuevosDados);
            }
            return dados;
        }

        /// <summary>
        /// El método verifica que el email y la clave coincidan con algún usuario dentro del archivo Json.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="clave"></param>
        /// <returns>Retorna un usuario en caso de coincidencia y un null en caso contrario.</returns>
        public static Usuario? Login(string email, string clave)
        {
            List<Usuario> lista = Soporte.UsuariosJson.Deserealizar(Soporte.usuariosJson.PathUsuarios);
            Usuario? aux = null;

            foreach (Usuario user in lista)
            {
                if (user.Correo == email && user.Clave == clave)
                {
                    aux = user;
                }
            }
            return aux;
        }
    }
}
