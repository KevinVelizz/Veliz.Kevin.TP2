using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;

namespace Entidades
{
    public sealed class Archivos
    {

        private static string pathSalas = Path.Combine(Archivos.TryGetSolutionDirectoryInfo().Parent.FullName, @"salas.json");

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

        public static void SerealizarSalas(List<SalaJuego> vuelos)
        {
            try
            {
                using (TextWriter writer = new StreamWriter(Archivos.pathSalas))
                {
                    writer.Write(JsonSerializer.Serialize(vuelos));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR:{ex.Message} - {ex.StackTrace}");
            }
        }

        public static List<SalaJuego> DeserealizarSalas()
        {
            List<SalaJuego> listaSalas = new List<SalaJuego>();
            if (File.Exists(Archivos.pathSalas))
            {
                try
                {
                    using (TextReader sr = new StreamReader(Archivos.pathSalas))
                    {
                        listaSalas = JsonSerializer.Deserialize<List<SalaJuego>>(sr.ReadToEnd()) ?? new();
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


    }
}
