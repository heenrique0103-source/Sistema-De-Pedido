using System;

namespace SistemaPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("       SISTEMA DE PEDIDO");
            Console.WriteLine("==================================");

            Cliente cliente = new Cliente();
            cliente.CadastrarCliente();

            Console.WriteLine("\n=== DADOS DO CLIENTE ===");
            cliente.ExibirDados();

            Produto produto = new Produto();
            produto.CadastrarProduto();
            produto.ExibirDados();

            Entrega entrega = new Entrega();
            entrega.EscolherEntrega();

            Console.WriteLine("\nPedido finalizado!");
        }
    }
}