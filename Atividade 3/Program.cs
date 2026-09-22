class Program
{
    static void Main()
    {
        List<Funcionario> funcionarios = new List<Funcionario>();
        int escolha = 0;
        while (escolha != 3)
        {
            Console.WriteLine("1 - Cadastrar funcionário");
            Console.WriteLine("2 - Listar funcionários");
            Console.WriteLine("3 - Sair");
            Console.Write("Digite a opção: ");
            escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
                Funcionario funcionario = new Funcionario();
                Console.Write("Nome: ");
                funcionario.Nome = Console.ReadLine();
                Console.Write("Idade: ");
                funcionario.Idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Cargo: ");
                funcionario.Cargo = Console.ReadLine();
                Console.Write("Salário: ");
                funcionario.Salario = Convert.ToDouble(Console.ReadLine());
                Console.Write("Setor: ");
                funcionario.Setor = Console.ReadLine();
                funcionarios.Add(funcionario);
                Console.WriteLine("Funcionário cadastrado!\n");
            }
            else if (escolha == 2)
            {
                foreach (Funcionario funcionario in funcionarios)
                    funcionario.Apresentar();
            }
        }
    }
}
