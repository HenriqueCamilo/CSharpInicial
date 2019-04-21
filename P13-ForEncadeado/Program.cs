using System;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13 - For encadeado!");

            // *
            // **
            // ***
            // ****

            for(int contadorLinha= 0; contadorLinha<10; contadorLinha++)
            {
                for(int contadorColuna = 0; contadorColuna <contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
