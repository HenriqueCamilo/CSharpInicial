using System;

namespace TestaEscopo
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;
            string IR = "";
            //De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
            //De 2800.01 até 3751.0, o IR é de 15 % e pode deduzir R$ 350;
            //De 3751.01 até 4664.00, o IR é de 22.5 % e pode deduzir R$ 636.

            if(salario >= 1900.00 && salario <= 2800.00)
            {
                IR = "o IR é de 7.5%";
                salario = salario - 142;
            }else if(salario >= 2800.01 && salario <= 3751.00)
            {
                IR = "o IR é de 15%";
                salario = salario - 350;
            }else if(salario >= 3751.01 && salario <= 4664.00){
                IR = "o IR é de 22,5%";
                salario = salario - 636;
            }
            else
            {
                IR = "o IR é 0%";
            }

            Console.WriteLine($"{IR} e o seu salario é {salario}");
            //ifs aqui
        }
    }
}
