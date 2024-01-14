using SistemaEstacionamento;
using System;

class Program
{
    static void Main()
    {
        Estacionamento estacionamento = new Estacionamento();

        while (true)
        {
            Console.WriteLine("Sistema de Estacionamento");
            Console.WriteLine("1. Adicionar veículo");
            Console.WriteLine("2. Remover veículo");
            Console.WriteLine("3. Listar veículos");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a placa do veículo: ");
                    string placa = Console.ReadLine();
                    Veiculo veiculo = new Veiculo(placa);
                    estacionamento.AdicionarVeiculo(veiculo);
                    Console.WriteLine("Veículo adicionado com sucesso.");
                    break;

                case "2":
                    Console.Write("Digite a placa do veículo a ser removido: ");
                    string placaRemover = Console.ReadLine();
                    decimal valorCobrado = estacionamento.RemoverVeiculo(placaRemover);
                    if (valorCobrado >= 0)
                    {
                        Console.WriteLine($"Veículo removido. Valor cobrado: {valorCobrado:C}");
                    }
                    else
                    {
                        Console.WriteLine("Veículo não encontrado.");
                    }
                    break;

                case "3":
                    estacionamento.ListarVeiculos();
                    break;

                case "4":
                    Console.WriteLine("Saindo do programa.");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
