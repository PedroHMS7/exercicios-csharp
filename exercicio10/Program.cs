using System;

namespace exercicio10
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

            int soma = nota1+nota2+nota3;
            double media = (double)soma/3;

            Console.WriteLine($"A média das três notas é: {media.ToString("F1")}");
        }
    }
}
