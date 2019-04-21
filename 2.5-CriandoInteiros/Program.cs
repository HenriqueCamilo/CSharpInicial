using System;

namespace _2._5_CriandoInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 10;

            Console.WriteLine($"A idade é {idade}" );

            idade = idade + 15 - 22 * 26 / 13;

            Console.WriteLine($"A idade é {idade}");

            Console.ReadLine();
        }
    }
}
