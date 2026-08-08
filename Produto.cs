using System;

namespace SistemaPedido
{
    public class Produto
    {
        public string Nome { get; set; } = string.Empty;
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double Subtotal { get; private set; }
        public double Desconto { get; private set; }
        public double ValorFinal { get; private set; }

        public void CadastrarProduto()
        {
            Console.WriteLine("\n=== DADOS DO PRODUTO ===");

            Console.Write("Produto: ");
            Nome = Console.ReadLine() ?? "";

            Console.Write("Quantidade: ");
            Quantidade = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Valor unitário: R$ ");
            ValorUnitario = double.Parse(Console.ReadLine() ?? "0");

            CalcularCompra();
        }

        private void CalcularCompra()
        {
            Subtotal = Quantidade * ValorUnitario;
            Desconto = Subtotal >= 200 ? Subtotal * 0.10 : 0;
            ValorFinal = Subtotal - Desconto;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Quantidade: {Quantidade}");
            Console.WriteLine($"Valor unitário: R$ {ValorUnitario:F2}");
            Console.WriteLine($"Subtotal: R$ {Subtotal:F2}");
            Console.WriteLine($"Desconto: R$ {Desconto:F2}");
            Console.WriteLine($"Valor final: R$ {ValorFinal:F2}");
        }
    }
}