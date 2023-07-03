
using System.Text.Json;
namespace Entidades
{
    public class ArchivoJson<T> : IArchivos<T> where T : class
    {
        private string pathSalas = Path.Combine(TryGetSolutionDirectoryInfo().Parent.FullName, @"salas.json");
        private string pathUsuarios = Path.Combine(TryGetSolutionDirectoryInfo().Parent.FullName, @"Usuarios.json");

        public string PathSalas { get => pathSalas; }
        public string PathUsuarios { get => pathUsuarios; }

        public static DirectoryInfo? TryGetSolutionDirectoryInfo(string currentPath = null)
        {
            DirectoryInfo? directory = new DirectoryInfo(currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("Program.cs").Any())
            {
                directory = directory.Parent;
            }
            return directory;
        }

        public List<T> Deserealizar(string path)
        {
            List<T> listaSalas = new List<T>();
            
            try
            {
                using (TextReader sr = new StreamReader(path))
                {
                    listaSalas = JsonSerializer.Deserialize<List<T>>(sr.ReadToEnd()) ?? new();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message} - {ex.StackTrace}");
            }
           
            return listaSalas;
        }

        public bool Serealizar(List<T> lista, string path)
        {
            bool retorno = false;
            try
            {
                using (TextWriter writer = new StreamWriter(path))
                {
                    writer.Write(JsonSerializer.Serialize(lista));
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR:{ex.Message} - {ex.StackTrace}");
            }
            return retorno;
        }
    }
}
