using System;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 10 - Calcula Poupança!");

            double valorInvestido = 1000.00;
            int contador = 1;

            while (contador <= 12)
            {
                valorInvestido += valorInvestido * 0.0036;// 0.36% = 0.0036

                Console.WriteLine($"Apos {contador} mes voce terá {valorInvestido}");

                contador++;

            }

            

            Console.ReadLine();
        }
    }
}
