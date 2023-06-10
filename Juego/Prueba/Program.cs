using Entidades;
internal class Program
{
    private static void Main(string[] args)
    {
        Jugador jugador = new Jugador("Mauricio");

        List<int> dados = new List<int>();
        dados.Add(1);
        dados.Add(4);
        dados.Add(4);
        dados.Add(4);
        dados.Add(4);

        

        if (Categorias.EsPoker(dados))
        {
            Console.WriteLine("es poker");
        }
        else
        {
            Console.WriteLine("no es poker");
        }

    }
}