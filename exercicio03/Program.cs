using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int A,B,C;

            Console.WriteLine("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            if(A==B)
            {
                C = A+B;
                Console.WriteLine($"Como A e B são iguais o valor de C é a soma entre eles: {C}");
            }
            else
            {
                C = A*B;
                Console.WriteLine($"Como A e B são diferentes o valor de C é a multiplicação entre eles: {C}");
            }
        }
    }
}
