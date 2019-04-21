using System;

namespace ConversoesEOutrosTiposNumericos2
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1270.50;
            int valor = (int)salario;

            Console.WriteLine(valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;

            Console.WriteLine(total);

            float pi = 3.14f;

            Console.WriteLine(pi);

            Console.ReadLine();
        }
    }
}
