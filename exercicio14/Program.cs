using System;

namespace exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor de A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B:");
            int b = int.Parse(Console.ReadLine());

            int novoA = b;
            int novoB = a;

            Console.WriteLine($"Novo valor de A: {novoA}");
            Console.WriteLine($"Novo valor de B: {novoB}");
        }
    }
}
