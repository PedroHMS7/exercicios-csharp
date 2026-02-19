using System;

namespace exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if(idade>=18)
            {
                Console.WriteLine($"{nome} é maior de idade com {idade} anos");
            }else{
                Console.WriteLine($"{nome} é menor de idade com {idade} anos");  
            }

        }
    }
}
