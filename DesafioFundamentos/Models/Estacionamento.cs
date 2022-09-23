namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();


            if (veiculos.Any(c => c.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Veiculo já cadastrado");
                return;
            }

            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                
                decimal valorTotal = precoInicial + precoPorHora * horas; 

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {

                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (string item in veiculos)
                {
                    Console.WriteLine($"Placa: {item}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void TabelaPreco()
        {

            Console.Clear();
            Console.WriteLine("_________________________________________________________________________");
            Console.WriteLine("|                      TABELA DE PRECO                                  |");
            Console.WriteLine("_________________________________________________________________________");

            Console.WriteLine($"Valor para entrada: {precoInicial}");
            Console.WriteLine($"Valor da Hora: {precoPorHora}");

            Console.WriteLine("\nDigite:\n 1 - Alterar tabela de valores\n 2 - Voltar ao menu principal");

            switch (Console.ReadLine())
            {
                case "1":
                    Atualizar();
                    break;

                case "2":
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Por favor digite uma opção válida...");
                    Console.WriteLine("Pressione uma tecla para continuar...");
                    Console.ReadLine();
                    TabelaPreco();
                    break;
            }

        }

        public void Atualizar()
        {
            Console.Clear();
            Console.WriteLine("_________________________________________________________________________");
            Console.WriteLine("|                          ATUALIZANDO VALORES                          |");
            Console.WriteLine("_________________________________________________________________________");

            Console.WriteLine($"O Valor para entrada atual é {precoInicial} \nDigite o novo valor:");
            precoInicial = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"O Valor da hora atual é {precoPorHora} \nDigite o novo valor:");
            precoPorHora = decimal.Parse(Console.ReadLine());
        }
    }
}
