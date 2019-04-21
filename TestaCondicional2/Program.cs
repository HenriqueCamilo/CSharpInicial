using System;

namespace TestaCondicional2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJ = 16;

            bool acompanhado;

            string mensagemAdicional;


            Console.WriteLine("Quantas pessoas tem?");
            int pessoas = Convert.ToInt32(Console.ReadLine());

            acompanhado = pessoas >= 2; // variavel booleana pegando resultado true ou false da expressao

            if (acompanhado == true)
            {
                mensagemAdicional = "Joao esta acompanhado";
            }
            else
            {
                mensagemAdicional = "Joao nao esta acompanhado";
            }

            if (idadeJ > 18 || acompanhado) // && para condicional "e"
            {
                Console.WriteLine("Seja bem vindo");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Joao não pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
        }
    }
}
