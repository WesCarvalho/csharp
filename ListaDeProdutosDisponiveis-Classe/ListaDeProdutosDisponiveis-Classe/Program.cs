using ListaDeProdutosDisponiveis_Classe.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeProdutosDisponiveis_Classe
{
    class Program
    {
        static void Main(string[] argumentos)
        {
            //criação da lista de produtos disponiveis no mercado
            List<Produto> produtosDisponiveis = new List<Produto>();
            produtosDisponiveis.Add(new Produto() { Nome = "Pão", Preco = 0.5 });
            produtosDisponiveis.Add(new Produto() { Nome = "Shampoo", Preco = 19.9 });
            produtosDisponiveis.Add(new Produto() { Nome = "Leite", Preco = 3.89 });
            produtosDisponiveis.Add(new Produto() { Nome = "Banana", Preco = 2.99 });
            produtosDisponiveis.Add(new Produto() { Nome = "Arroz", Preco = 19.99 });

            //validação da quantidade de argumentos
            if(argumentos.Length == 0)
            {
                Console.WriteLine("Nenhum produto informado.");
                return;
            }

            //faz a comparação dos argumentos com os produtos disponiveis
            var produtosSelecionadosDisponiveis = produtosDisponiveis.Where(produto =>
                                                    argumentos.Any(argumento => produto.Nome.ToUpper() == argumento.ToUpper()));
            //loop para exibir na tela os dados dos produtos selecionados que estão disponiveis.
            foreach(var produto in produtosSelecionadosDisponiveis)
            {
                Console.WriteLine($"Este produto nós temos: {produto.ExibirDadosProduto()}");
            }

            //Exibe os produtos selecionados que não estão disponiveis
            var produtosSelecionadosNãoDisponiveis = argumentos.Where(argumento =>
                                                     !produtosDisponiveis.Any(produto => produto.Nome.ToUpper() == argumento.ToUpper()));
            foreach(var produtoNaoDisponivel in produtosSelecionadosNãoDisponiveis)
            {
                Console.WriteLine($"Este produto nós não temos: {produtoNaoDisponivel}");
            }

            //exibir a lista de produtos disponiveis ordenado por nome
            var produtosOrdenadosPorNome = produtosDisponiveis.OrderBy(produto => produto.Nome).ToList();

            Console.WriteLine("Nossa lista de produtos:");
            foreach (var produtoOrdenado in produtosOrdenadosPorNome)
            {
                Console.WriteLine(produtoOrdenado.ExibirDadosProduto());
            }
        }
    }
}
