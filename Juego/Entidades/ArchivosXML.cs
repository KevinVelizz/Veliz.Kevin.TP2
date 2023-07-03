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


        /// <summary>
        /// El metodo deserealiza una lista de cualquier tipo de dato.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Retorna la lista obtenida en la lectura.</returns>
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


        /// <summary>
        /// El método serealiza una lista del tipo de dato la cual se haya inicializado la clase.
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="path"></param>
        /// <returns>Retorna un true en caso de exito o false en caso de fracaso.</returns>
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
