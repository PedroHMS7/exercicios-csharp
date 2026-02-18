using System;

namespace exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua primeira nota: ");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua segunda nota: ");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota: ");
            int nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua quarta nota: ");
            int nota4 = int.Parse(Console.ReadLine());

            int soma = nota1+nota2+nota3+nota4;
            double media = (double)soma/4;

            if(media>=7)
            {
                Console.WriteLine($"Aluno Aprovado! Com média: {media.ToString("F1")}");
            }
            else Console.WriteLine($"Aluno Reprovado! Com média: {media.ToString("F1")}");

        }
    }
}
