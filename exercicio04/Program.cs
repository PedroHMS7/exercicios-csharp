using System;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,ant,suc;

            Console.WriteLine("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            ant = num -1;
            suc = num +1;

            Console.WriteLine($"O número {suc} é o sucessor de {num} e {ant} é o antecessor");           
        }
    }
}
