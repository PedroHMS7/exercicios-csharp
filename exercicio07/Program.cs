using System;

namespace exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
           bool x,y;

           Console.WriteLine("Digite o valor lógico de X (TRUE/FALSE): ");
           x = bool.Parse(Console.ReadLine());

           Console.WriteLine("Digite o valor lógico de Y (TRUE/FALSE): ");
           y = bool.Parse(Console.ReadLine());

           if(x == y)
           {
                Console.WriteLine("Os dois valores são iguais (TRUE ou FALSE)");
           }
           else Console.WriteLine("Os dois valores são diferentes");
        }
    }
}
