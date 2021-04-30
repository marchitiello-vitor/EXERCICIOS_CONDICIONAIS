using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >=5 && idade <=7)
            {
                // código 1
                Console.WriteLine("Você se encaixa na faixa infantil A!");

            }
            else if(idade >=8 && idade <=10)
            {

                // código 2
                Console.WriteLine("Você se encaixa na faixa infantil B!");

            }
            else if(idade >=11 && idade <=13)
            {
                
                // código 3
                Console.WriteLine("Você se encaixa na faixa jovem dinamico A!");

            }
            else if(idade >=14 && idade <=17)
            {

                // código 4
                Console.WriteLine("Você se encaixa na faixa jovem dinamica B!");

            }
            else if(idade >=18)
            {

                // código 5
                Console.WriteLine("Você se encaixa na faixa senior!");

            }
            else {

                // código 6
                Console.WriteLine("Infelizmente você não puedes entrar ainda, cresca mais!");
                Console.WriteLine("\nCategorizador Finalizado.");

            }
        }
    }
}
