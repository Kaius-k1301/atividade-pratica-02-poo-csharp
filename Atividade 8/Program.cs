class Program
{
    static void Main()
    {
        List<Pedido> pedidos = new List<Pedido>();
        int escolha = 0;
        while (escolha != 3)
        {
            Console.WriteLine("1 - Cadastrar pedido");
            Console.WriteLine("2 - Listar pedidos");
            Console.WriteLine("3 - Sair");
            Console.Write("Digite a opção: ");
            escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
                Pedido pedido = new Pedido();
                Console.Write("Número: ");
                pedido.Numero = Console.ReadLine();
                Console.Write("Cliente: ");
                pedido.Cliente = Console.ReadLine();
                Console.Write("Produto: ");
                pedido.Produto = Console.ReadLine();
                Console.Write("Quantidade: ");
                pedido.Quantidade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Valor unitário: ");
                pedido.ValorUnitario = Convert.ToDouble(Console.ReadLine());
                pedidos.Add(pedido);
                Console.WriteLine("Pedido cadastrado!\n");
            }
            else if (escolha == 2)
            {
                foreach (Pedido pedido in pedidos)
                    pedido.MostrarPedido();
            }
        }
    }
}
