using System;

namespace TesteVariavelConstante
{
    class Program
    {
        static void Main(string[] argumentos)
        {
            const string constante = "uma variavel que não muda";
           if(argumentos.Length == 0)
            {
                Console.WriteLine("Favor informar um numero inteiro");
                return;
            }

            int inteiro;
            bool teste = int.TryParse(argumentos[0], out inteiro);

            if(teste == false)
            {
                Console.WriteLine("O argumento informado não é um numero inteiro");
                return;
            }

            Console.WriteLine(constante);
            Console.WriteLine("O numero informado foi:" + inteiro);
        }
    }
}
