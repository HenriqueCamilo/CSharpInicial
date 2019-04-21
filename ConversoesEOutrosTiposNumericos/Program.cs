using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            int salarioInteiro; // variavel de 32 bits

            salarioInteiro = (int)salario;

            Console.WriteLine(salarioInteiro);

            //long idade;
            //idade = 13000000000000000; Quantidade de valor muito grande, onde o int n cabe 64 bits

            //short quantidadeProdutos = 150;
            //Quantidade muito pequena! 16 bits

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
