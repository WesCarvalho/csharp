using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeProdutosDisponiveis
{
    class Program
    {     
        static void Main(string[] argumentos)
        {
            // criar a lista de produtos que o mercado tem
            List<string> produtosDisponiveis = new List<string>()
          {
              "pão", "leite", "manteiga", "requeijão", "refrigerante", "arroz", "alface", "tomate","frango","doce"
          };
            // validar se os argumentos foram preenchidos
            try
            {
                // listar quais produtos informados do argumento tem na lista do mercado
                var produtosSelecionados = produtosDisponiveis.Where(produto => argumentos.Contains(produto)).ToList();
                foreach (var produtoSelecionado in produtosSelecionados)
                {
                    Console.WriteLine($"Este produto nós temos: {produtoSelecionado}");
                }

                //listar quais produtos informados no argumento não tem no mercado
                var produtosNaoDisponiveis = argumentos.Where(argumento => !produtosDisponiveis.Contains(argumento)).ToList();
                foreach (var produtoNaoDisponivel in produtosNaoDisponiveis)
                {
                    Console.WriteLine($"Este produto nós não temos: {produtoNaoDisponivel}");
                }
                // retornar a lista de produtos disponiveis do mercado ORDENADOS em ordem alfabetica
                var produtosDisponiveisOrdenadosPorNome = produtosDisponiveis.OrderBy(e => e).ToList();
                foreach( var produtoOrdenado in produtosDisponiveisOrdenadosPorNome)
                {
                    Console.WriteLine($"Segue este produto disponivel: {produtoOrdenado}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Argumentos invalidos.");
            }
        }
    }
}
