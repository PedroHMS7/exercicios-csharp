using System;

namespace exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine($"{a} - {b} - {c}");
                }
                else Console.WriteLine($"{a} - {c} - {b}");
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine($"{b} - {a} - {c}");
                }
                else Console.WriteLine($"{b} - {c} - {a}");  
            }
            else
            {
                if(b>a)
                {
                    Console.WriteLine($"{c} - {b} - {a}");
                }
                else  Console.WriteLine($"{c} - {a} - {b}");
            }
        }
    }
}