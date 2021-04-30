using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());
            
            int idadeMeses = idade * 12;
            int idadeDias = idade * 365;
            int idadeHoras = idadeDias * 24;
            int idadeMinutos = idadeHoras * 60;

            Console.WriteLine("Sua idade em meses: " + idadeMeses);
            Console.WriteLine("Sua idade em dias: " + idadeDias);
            Console.WriteLine("Sua idade em horas: " + idadeHoras);
            Console.WriteLine("Sua idade em minutos: " + idadeMinutos);
        }
    }
}
