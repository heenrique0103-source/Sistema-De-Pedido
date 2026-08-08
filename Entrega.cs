using System;

namespace SistemaPedido
{
    public class Entrega
    {
        public string TipoEntrega { get; set; } = string.Empty;
        public double ValorFrete { get; private set; }

        public void EscolherEntrega()
        {
            Console.WriteLine("\n=== FORMA DE ENTREGA ===");
            Console.WriteLine("1 - Retirada na loja");
            Console.WriteLine("2 - Entrega comum");
            Console.WriteLine("3 - Entrega expressa");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "1":
                    TipoEntrega = "Retirada na loja";
                    ValorFrete = 0;
                    Console.WriteLine("Retirada na loja selecionada.");
                    break;

                case "2":
                    TipoEntrega = "Entrega comum";
                    ValorFrete = 15.00;
                    Console.WriteLine("Entrega comum selecionada.");
                    Console.WriteLine($"Valor do frete: R$ {ValorFrete:F2}");
                    break;

                case "3":
                    TipoEntrega = "Entrega expressa";
                    ValorFrete = 30.00;
                    Console.WriteLine("Entrega expressa selecionada.");
                    Console.WriteLine($"Valor do frete: R$ {ValorFrete:F2}");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Retirada na loja selecionada por padrão.");
                    TipoEntrega = "Retirada na loja";
                    ValorFrete = 0;
                    break;
            }
        }
    }
}