class Program
{
    static void Main()
    {
        List<Livro> livros = new List<Livro>();
        int escolha = 0;
        while (escolha != 3)
        {
            Console.WriteLine("1 - Cadastrar livro");
            Console.WriteLine("2 - Listar livros");
            Console.WriteLine("3 - Sair");
            Console.Write("Digite a opção: ");
            escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
                Livro livro = new Livro();
                Console.Write("Título: ");
                livro.Titulo = Console.ReadLine();
                Console.Write("Autor: ");
                livro.Autor = Console.ReadLine();
                Console.Write("Ano: ");
                livro.Ano = Convert.ToInt32(Console.ReadLine());
                Console.Write("Categoria: ");
                livro.Categoria = Console.ReadLine();
                Console.Write("Está disponível? (s/n): ");
                livro.Disponivel = Console.ReadLine().ToLower() == "s";
                livros.Add(livro);
                Console.WriteLine("Livro cadastrado!\n");
            }
            else if (escolha == 2)
            {
                Console.WriteLine("\nLIVROS CADASTRADOS");
                foreach (Livro livro in livros)
                    livro.MostrarLivro();
            }
        }
    }
}
