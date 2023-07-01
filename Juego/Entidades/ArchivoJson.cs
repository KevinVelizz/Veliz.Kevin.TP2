
using System.Text.Json;
namespace Entidades
{
    public class ArchivoJson <T> : IArchivos <T> where T : class
    {

        private static string pathSalas = Path.Combine(TryGetSolutionDirectoryInfo().Parent.FullName, @"salas.json");
        public static DirectoryInfo? TryGetSolutionDirectoryInfo(string currentPath = null)
        {
            DirectoryInfo? directory = new DirectoryInfo(currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("Program.cs").Any())
            {
                directory = directory.Parent;
            }
            return directory;
        }

        public static string PathSalas
        {
            get { return pathSalas; }
        }

        public List<T> Deserealizar()
        {
            List<T> listaSalas = new List<T>();
            if (File.Exists(pathSalas))
            {
                try
                {
                    using (TextReader sr = new StreamReader(pathSalas))
                    {
                        listaSalas = JsonSerializer.Deserialize<List<T>>(sr.ReadToEnd()) ?? new();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message} - {ex.StackTrace}");
                }
            }
            else
            {
                Console.WriteLine("No existe el archivo");
            }
            return listaSalas;
        }
    
        public bool Serealizar(List<T> lista)
        {
            bool retorno = false;
            try
            {
                using (TextWriter writer = new StreamWriter(pathSalas))
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
