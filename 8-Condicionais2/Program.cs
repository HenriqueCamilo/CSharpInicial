using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJ = 16;

            bool acompanhado;

            Console.WriteLine("Quantas pessoas tem?");
            int pessoas = Convert.ToInt32(Console.ReadLine());

            acompanhado = pessoas >= 2; // variavel booleana pegando resultado true ou false da expressao

            if (idadeJ > 18 || acompanhado) // && para condicional "e"
            {
                Console.WriteLine("Joao pode entrar");
            }else


            {
                Console.WriteLine("Joao não pode entrar");
            }
        }
    }
}
