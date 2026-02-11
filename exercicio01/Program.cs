using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int A,B,C,soma=0;

            Console.WriteLine("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            C = int.Parse(Console.ReadLine());

            soma = A+B;
            Console.WriteLine("A soma de A e B é: "+ soma);

            if(soma<C)
            {
                Console.WriteLine(soma + " é menor que " + C);
            }
            else Console.WriteLine(soma + " não é menor que " + C);
        }
    }
}
