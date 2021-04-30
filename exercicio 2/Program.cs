using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano de seu nascimento: ");
            int nascimento = int.Parse(Console.ReadLine());
            // Console.WriteLine("Digite o ano atual: ");
            // int Atual = int.Parse(Console.ReadLine());
            int Atual = DateTime.Now.Year;

            int diferença = Atual - nascimento; 

            Console.WriteLine("Sua idade: " + diferença);
            int semanas = diferença * 52;
            Console.WriteLine("Sua idade em semanas: " + semanas);
        
        }
    }
}
