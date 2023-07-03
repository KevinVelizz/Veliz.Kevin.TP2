using System.Xml.Serialization;
using System.Xml;
using System.Text;

namespace Entidades
{
    public sealed class ArchivosXML<T> : IArchivos<T> where T : class
    {
        private string pathSalas = Path.Combine(TryGetSolutionDirectoryInfo().Parent.FullName, @"salas.json");
        public static DirectoryInfo? TryGetSolutionDirectoryInfo(string currentPath = null)
        {
            DirectoryInfo? directory = new DirectoryInfo(currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("Program.cs").Any())
            {
                directory = directory.Parent;
            }
            return directory;
        }


        public string PathSalas
        {
            get { return this.pathSalas; }
        }



        public List<T> Deserealizar(string path)
        {
            List<T> listXML = new List<T>();
            try
            {
                using (XmlTextReader sr = new XmlTextReader(path))
                {
                    XmlSerializer serializer = new XmlSerializer((typeof(List<T>)));
                    listXML = serializer.Deserialize(sr) as List<T> ?? new();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message} - {ex.StackTrace}");
            }
            return listXML;
        }

        public bool Serealizar(List<T> lista, string path)
        {
            bool retorno = false;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<T>)));
                    ser.Serialize(writer, lista);
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
