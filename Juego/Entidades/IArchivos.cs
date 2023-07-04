using System.Xml.Serialization;
using System.Xml;
using System.Text;

namespace Entidades
{
    public interface IArchivos <T> where T : class
    {


        public bool Serealizar(List<T> lista, string path);
        

        public List<T> Deserealizar(string path);
        
           
    }
}
