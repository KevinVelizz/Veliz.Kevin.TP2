using System.Xml.Serialization;
using System.Xml;
using System.Text;

namespace Entidades
{
    public sealed class ArchivosXML<T> : IArchivos<T> where T : class
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
            List<T> listXML = new List<T>();
            string pathAux = "";
           
            try
            {
                using (XmlTextReader sr = new XmlTextReader(pathAux))
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

        public bool Serealizar(List<T> lista)
        {
            bool retorno = false;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(pathSalas, Encoding.UTF8))
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
