using Entidades;
internal class Program
{
    private static void Main(string[] args)
    {
        
        SalaJuego salaJuego = new SalaJuego("Kevin", "Elias");


        Jugador jugador = new Jugador("Kevin");


        Categorias categorias = new Categorias();

        List<int> dados = new List<int>();
        dados.Add(1);dados.Add(1);dados.Add(1);dados.Add(5);dados.Add(2);

        int numero = categorias.CalculaTipoCategoria(dados);
        Console.WriteLine(numero + "debe salir 3");

        numero = categorias.CalculaTipoCategoria(dados);
        Console.WriteLine(numero + "debe salir 5");

        numero = categorias.CalculaTipoCategoria(dados);
        Console.WriteLine(numero + "debe salir 2");
        dados.Clear();

        dados.Add(4); dados.Add(4); dados.Add(4); dados.Add(6); dados.Add(3);
        numero = categorias.CalculaTipoCategoria(dados);
        Console.WriteLine(numero + "debe salir 12");

        numero = categorias.CalculaTipoCategoria(dados);
        Console.WriteLine(numero + "debe salir 6");

        numero = categorias.CalculaTipoCategoria(dados);
        Console.WriteLine(numero + "debe salir 3");

        numero = categorias.CalculaTipoCategoria(dados);
        Console.WriteLine($"7mo tiro {numero}");
    }
}