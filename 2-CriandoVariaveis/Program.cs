using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;
            idade = 32;
             
            Console.WriteLine("A IDADE É " + idade);

            idade = 10;

            Console.WriteLine("A IDADE É " + idade);

            idade = 10 + 5;

            Console.WriteLine("A IDADE É " + idade);

            Console.WriteLine("Aperte enter para encerrar...");
            Console.ReadLine();
        }
    }
}
