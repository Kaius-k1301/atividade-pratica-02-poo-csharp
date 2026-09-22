class Program
{
    static void Main()
    {
        List<Curso> cursos = new List<Curso>();
        int escolha = 0;
        while (escolha != 3)
        {
            Console.WriteLine("1 - Cadastrar curso");
            Console.WriteLine("2 - Listar cursos");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("4 - Ver cursos disponíveis");
            Console.Write("Digite a opção: ");
            escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
                Curso curso = new Curso();
                Console.Write("Nome: ");
                curso.Nome = Console.ReadLine();
                Console.Write("Carga horária: ");
                curso.CargaHoraria = Convert.ToInt32(Console.ReadLine());
                Console.Write("Professor: ");
                curso.Professor = Console.ReadLine();
                Console.Write("Modalidade: ");
                curso.Modalidade = Console.ReadLine();
                Console.Write("Quantidade de vagas: ");
                curso.QuantidadeVagas = Convert.ToInt32(Console.ReadLine());
                cursos.Add(curso);
                Console.WriteLine("Curso cadastrado!\n");
            }
            else if (escolha == 2)
            {
                foreach (Curso curso in cursos)
                    curso.MostrarCurso();
            }
            else if (escolha == 4)
            {
                Console.WriteLine("\nCURSOS DISPONÍVEIS");
                foreach (Curso curso in cursos)
                    if (curso.QuantidadeVagas > 0)
                        curso.MostrarCurso();
            }
        }
    }
}
