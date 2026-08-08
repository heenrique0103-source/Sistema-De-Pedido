Sistema de Pedido

Exercício de POO em C# feito durante o curso de Back-End no SENAI. A ideia era simular o fluxo de um pedido numa loja, separando as responsabilidades em classes diferentes.

O que o sistema faz
Cadastro do cliente (nome, idade, cidade)
Calcule o pedido: quantidade x valor unitário, com desconto de 10% pra compras acima de R$ 200
Deixar escolher a forma de entrega (retirada, entrega comum ou expressa), cada uma com um valor de frete diferente
Mostra o resumo de tudo no final
Estrutura
SistemaPedido
├── Program.cs    -> chama as classes e organiza o fluxo
├── Cliente.cs    -> cadastro do cliente
├── Produto.cs    -> cálculo da compra
└── Entrega.cs    -> escolha do frete


Sobre o projeto

Cada classe cuida só da sua parte (Cliente não sabe nada de design, Produto não sabe nada de entrega). O Program.cs só chama os métodos na ordem certa.

Ainda dá pra melhorar bastante — hoje o Console.ReadLine() fica direto dentro das classes, o que mistura entrada de dados com regra de negócio. Numa versão mais organizada isso ficaria separado.