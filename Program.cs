using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");

// Entrada do preço inicial
while (true)
{
    Console.Write("Digite o preço inicial: ");
    if (decimal.TryParse(Console.ReadLine(), out precoInicial) && precoInicial >= 0)
        break;
    Console.WriteLine("Valor inválido. Digite um número válido maior ou igual a zero.");
}

// Entrada do preço por hora
while (true)
{
    Console.Write("Digite o preço por hora: ");
    if (decimal.TryParse(Console.ReadLine(), out precoPorHora) && precoPorHora >= 0)
        break;
    Console.WriteLine("Valor inválido. Digite um número válido maior ou igual a zero.");
}

// Instancia a classe Estacionamento
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("===================================");
    Console.WriteLine("  SISTEMA DE ESTACIONAMENTO");
    Console.WriteLine("===================================");
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    Console.Write("Opção: ");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            Console.Write("Tem certeza que deseja encerrar? (S/N): ");
            string confirmacao = Console.ReadLine()?.Trim().ToUpper();
            if (confirmacao == "S")
            {
                exibirMenu = false;
                Console.WriteLine("Encerrando o sistema...");
            }
            else
            {
                Console.WriteLine("Operação cancelada.");
            }
            break;

        default:
            Console.WriteLine("Opção inválida. Por favor, digite uma opção de 1 a 4.");
            break;
    }

    if (exibirMenu)
    {
        Console.WriteLine("\nPressione Enter para continuar...");
        Console.ReadLine();
    }
}

Console.WriteLine("O programa foi encerrado. Obrigado!");
