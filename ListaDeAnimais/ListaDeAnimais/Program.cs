using ListaDeAnimais.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeAnimais
{
    class Program
    {
        static void Main(string[] argumentos)
        {
            //Receber um nome de animal
            Console.WriteLine("Digite o nome de um animal:");
            var nomeAnimal = Console.ReadLine();

            //validar se o nome informado está vazio ou em branco
            if (string.IsNullOrEmpty(nomeAnimal) || string.IsNullOrWhiteSpace(nomeAnimal))
            {
                Console.WriteLine("Favor passar um nome de animal vertebrado válido!");
                return;
            }

            // criação da lista contendo os animais vertebrados
            var listaDeAnimais = new List<Animal>();
            listaDeAnimais.Add(new Mamifero() { Nome = "Vaca", QuantidadeDeMamas = 4 });
            listaDeAnimais.Add(new Reptil() { Nome = "Cobra" });
            listaDeAnimais.Add(new Ave() { Nome = "Gavião" });
            listaDeAnimais.Add(new Peixe() { Nome = "Tubarão", QuantidadeNadadeiras = 2 });

            // verifica se o animal selecionado existe na lista
            var animalSelecionado = listaDeAnimais.FirstOrDefault(animal => animal.Nome.ToUpper() == nomeAnimal.ToUpper());

            //informa o usuario caso o animal não esteja na lista
            if (animalSelecionado == null)
            {
                Console.WriteLine("O animal não está na nossa lista!");
                return;
            }

            //informa ao usuario qual é a classe do animal
            if (animalSelecionado is Mamifero)
            {
                Console.WriteLine($"O animal encontrado é um mamifero chamado {animalSelecionado.Nome} e tem {((Mamifero)animalSelecionado).QuantidadeDeMamas} mamas");
            }
            else if (animalSelecionado is Reptil)
            {
                Console.WriteLine($"O animal encontrado é um réptil chamado {animalSelecionado.Nome} e não sabe controlar sua temperatura");
            }
            else if (animalSelecionado is Ave)
            {
                Console.WriteLine($"O animal encontrado é uma ave chamado {animalSelecionado.Nome} e tem penas");
            }
            else if (animalSelecionado is Peixe)
            {
                Console.WriteLine($"O animal encontrado é um peixe chamado {animalSelecionado.Nome} e tem {((Peixe)animalSelecionado).QuantidadeNadadeiras} nadadeiras");
            }
            else
            {
                Console.WriteLine($"O animal encontrado chamado {animalSelecionado.Nome} não pertence aos animais vertebrados.");
            }
        }
    }
}

