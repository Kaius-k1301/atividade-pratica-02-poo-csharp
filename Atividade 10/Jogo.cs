class Jogo
{
    public int Codigo;
    public string Titulo;
    public string Plataforma;
    public string Genero;
    public int Ano;
    public double Nota;

    public void MostrarJogo()
    {
        Console.WriteLine("Código: " + Codigo);
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Plataforma: " + Plataforma);
        Console.WriteLine("Gênero: " + Genero);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Nota: " + Nota);
        Console.WriteLine();
    }
}
