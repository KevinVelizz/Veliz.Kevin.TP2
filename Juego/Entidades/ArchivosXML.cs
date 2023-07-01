
namespace Entidades
{
    public sealed class ArchivosXML<T> : IArchivos<T> where T : class
    {
        public List<T> Deserealizar()
        {
            throw new NotImplementedException();
        }

        public bool Serealizar(List<T> lista)
        {
            throw new NotImplementedException();
        }
    }
}
