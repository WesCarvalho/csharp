using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeProdutosDisponiveis_Classe.Classes
{
    class Produto
    {
        public string Nome { get; set; } //atributo
        public double Preco { get; set; } //atributo

        public string ExibirDadosProduto()
        {
            return $"{Nome} - R$ {Preco}"; //comportamento da classe (método da classe)
        }
    }
}
