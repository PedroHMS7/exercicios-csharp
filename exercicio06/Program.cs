using System;

namespace exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            double reajuste,valor;

            Console.WriteLine("Informe um valor: ");
            valor = double.Parse(Console.ReadLine());

            reajuste = (valor * 0.05) + valor;

            Console.WriteLine($"Valor com reajuste de 5%: {reajuste}");
        }
    }
}
