using System;

namespace SistemaPedido
{
    public class Cliente
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public string Cidade { get; set; } = string.Empty;

        public void CadastrarCliente()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine() ?? "";

            Console.Write("Idade: ");
            Idade = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Cidade: ");
            Cidade = Console.ReadLine() ?? "";
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Cidade: {Cidade}");
        }
    }
}