using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu salario?: ");
            int salario = int.Parse(Console.ReadLine());

            if (salario <= 500)
            {
                // código 1
                int Beneficio = (int)(salario * 1.3);
                Console.WriteLine("Você foi aprovado para receber o beneficio. Seu salario atual é: " + Beneficio);
            }
            else
            {
                // código 2
                Console.WriteLine("Você foi recusado para o beneficio.");
            }
        }
    }
}
