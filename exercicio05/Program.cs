using System;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantSalario,salario, salarioMin;

            Console.WriteLine("Digite o salário mínimo: ");
            salarioMin = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu salário: ");
            salario = double.Parse(Console.ReadLine());

            quantSalario = salario/salarioMin;
            Console.WriteLine($"Você recebe {quantSalario.ToString("F2")} vezes o salário mínimo");
            
        }
    }
}
