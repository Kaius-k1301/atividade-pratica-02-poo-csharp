class Program
{
    static void Main()
    {
        List<Jogo> jogos = new List<Jogo>();
        int escolha = 0;

        while (escolha != 7)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("CATÁLOGO DE JOGOS");
            Console.WriteLine("========================================");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Pesquisar");
            Console.WriteLine("4 - Alterar");
            Console.WriteLine("5 - Excluir");
            Console.WriteLine("6 - Relatório");
            Console.WriteLine("7 - Sair");
            Console.Write("Opção: ");
            escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
                Jogo jogo = new Jogo();
                Console.Write("Código: ");
                jogo.Codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Título: ");
                jogo.Titulo = Console.ReadLine();
                Console.Write("Plataforma: ");
                jogo.Plataforma = Console.ReadLine();
                Console.Write("Gênero: ");
                jogo.Genero = Console.ReadLine();
                Console.Write("Ano: ");
                jogo.Ano = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nota: ");
                jogo.Nota = Convert.ToDouble(Console.ReadLine());
                jogos.Add(jogo);
                Console.WriteLine("Jogo cadastrado!\n");
            }
            else if (escolha == 2)
            {
                foreach (Jogo jogo in jogos)
                    jogo.MostrarJogo();
            }
            else if (escolha == 3)
            {
                Console.Write("Digite o título: ");
                string titulo = Console.ReadLine().ToLower();
                foreach (Jogo jogo in jogos)
                    if (jogo.Titulo.ToLower().Contains(titulo))
                        jogo.MostrarJogo();
            }
            else if (escolha == 4)
            {
                Console.Write("Código do jogo: ");
                int codigo = Convert.ToInt32(Console.ReadLine());
                Jogo achado = null;
                foreach (Jogo jogo in jogos)
                    if (jogo.Codigo == codigo)
                        achado = jogo;

                if (achado != null)
                {
                    Console.Write("Novo título: ");
                    achado.Titulo = Console.ReadLine();
                    Console.Write("Nova nota: ");
                    achado.Nota = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Jogo alterado!\n");
                }
                else
                    Console.WriteLine("Jogo não encontrado.\n");
            }
            else if (escolha == 5)
            {
                Console.Write("Código do jogo: ");
                int codigo = Convert.ToInt32(Console.ReadLine());
                Jogo achado = null;
                foreach (Jogo jogo in jogos)
                    if (jogo.Codigo == codigo)
                        achado = jogo;
                if (achado != null)
                {
                    jogos.Remove(achado);
                    Console.WriteLine("Jogo excluído!\n");
                }
                else
                    Console.WriteLine("Jogo não encontrado.\n");
            }
            else if (escolha == 6)
            {
                Console.WriteLine("Jogos cadastrados: " + jogos.Count);
                int bemAvaliados = 0;
                foreach (Jogo jogo in jogos)
                    if (jogo.Nota >= 8)
                        bemAvaliados++;
                Console.WriteLine("Jogos com nota 8 ou maior: " + bemAvaliados + "\n");
            }
        }
    }
}
