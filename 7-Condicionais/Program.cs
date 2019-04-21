using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJ = 16;

            Console.WriteLine("Quantas pessoas tem?");
            int pessoas = Convert.ToInt32(Console.ReadLine());

            if (idadeJ > 18)
            {
                Console.WriteLine("Joao pode entrar");
            }
            else if (pessoas >= 2)
            {
                Console.WriteLine("Joao nao pode entrar, mas ele esta acompanhado, pode entrar sim");
            }
            else
            {
                Console.WriteLine("Joao não pode entrar");
            }
        }
    }
}
