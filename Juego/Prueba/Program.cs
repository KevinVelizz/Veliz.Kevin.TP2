using Entidades;
internal class Program
{
    private static void Main(string[] args)
    {
        Jugador jugador = new Jugador("Mauricio");

        List<int> dados = jugador.LanzarDados();

        foreach (int dado in dados)
        {
            Console.WriteLine(dado.ToString());    
        } 
    }
}