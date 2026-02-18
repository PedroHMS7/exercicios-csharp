using System;

namespace exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco;

            Console.WriteLine("Informe o valor do produto: ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Informe a forma de pagamento: ");
            Console.WriteLine("1-À Vista em Dinheiro ou Pix, recebe 15% de desconto");
            Console.WriteLine("2-À Vista no cartão de crédito, recebe 10% de desconto");
            Console.WriteLine("3-Parcelado no cartão em duas vezes, preço normal do produto sem juros");
            Console.WriteLine("4-Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10%");
            int pag = int.Parse(Console.ReadLine());

            Console.WriteLine();
            switch (pag)
            {
                case 1:
                    {
                        preco = valor - (valor * 0.15);
                        Console.WriteLine($"O preço final é R$ {preco}");
                        break;
                    }
                case 2:
                    {   
                        preco = valor - (valor * 0.10);
                        Console.WriteLine($"O preço final é R$ {preco}");
                        break;           
                    }
                case 3:
                    {
                        Console.WriteLine($"O preço final é R$ {valor}");
                        break;   
                    }
                case 4:
                    {
                        preco = valor + (valor * 0.10);;
                        Console.WriteLine($"O preço final é R$ {preco}");
                        break;
                    }    
                default:
                    {
                        Console.WriteLine("Opção inválida!");
                        break;
                    }
            }
        }
    }
}
