using System;

namespace exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura;

            Console.WriteLine("Informe seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura: ");
            altura = double.Parse(Console.ReadLine());

            double imc = peso/Math.Pow(altura,2);
            Console.WriteLine($"IMC:{imc.ToString("F2")}");

            if(imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if(imc < 25)
            {
                Console.WriteLine("Peso ideal (Parabéns!)");
            }
            else if(imc < 30)
            {
                Console.WriteLine("Levemente acima do peso");
            }
            else if(imc < 35)
            {
                Console.WriteLine("Obesidade grau I");
            }
            else if(imc < 40)
            {
                Console.WriteLine("Obesidade grau II (severa)");
            }
            else 
            {
                Console.WriteLine("Obesidade grau III (mórbida)");
            }
        }
    }
}
