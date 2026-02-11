using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Informe um número: ");
            num = int.Parse(Console.ReadLine());

            if(num == 0)
            {   
                Console.WriteLine("O número 0 é par e neutro (não é positivo nem negativo)");
            }
            else if(num % 2 == 0 && num > 0)
            {
                Console.WriteLine($"O número {num} é par e positivo");
            }
            else if(num % 2 == 0 && num < 0)
            {
                Console.WriteLine($"O número {num} é par e negativo");
            }
            else if(num % 2 != 0 && num > 0)
            {
                Console.WriteLine($"O número {num} é ímpar e positivo");
            }
            else Console.WriteLine($"O número {num} é ímpar e negativo");
        }
    }
}
