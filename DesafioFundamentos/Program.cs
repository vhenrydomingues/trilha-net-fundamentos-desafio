using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 5;
decimal precoPorHora = 10;


Console.WriteLine("_________________________________________________________");
Console.WriteLine("|                SEJA BEM VINDO!                        |");
Console.WriteLine("|            SISTEMA DE ESTACIONAMENTO                  |");
Console.WriteLine("_________________________________________________________");
// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

Console.WriteLine("Pressione uma tecla para continuar...");
Console.ReadLine();
// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("_________________________________________________________");
    Console.WriteLine("|                    MENU PRINCIPAL                     |");
    Console.WriteLine("_________________________________________________________");
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Consultar tabela de preço");
    Console.WriteLine("5 - Encerrar o sistema");

    switch (Console.ReadLine())
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
            es.TabelaPreco();
            break;

        case "5":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar...");
    Console.ReadLine();
}

Console.WriteLine("Obrigado por utilizar o nosso sistema, até a proxima!");
Console.WriteLine("O programa se encerrou");
