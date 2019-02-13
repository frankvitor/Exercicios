using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, divisor;
            string entrada;

            Console.WriteLine("Olá\n\n");
            Console.WriteLine("Entre com um número");
            entrada = Console.ReadLine();

            while (string.IsNullOrEmpty(entrada) || !int.TryParse(entrada, out numero))
            {
                Console.WriteLine("Errou!!\n\n");
                Console.WriteLine("Entre com um número");
                entrada = Console.ReadLine();
            }

            Console.WriteLine("Entre com o divisor");
            entrada = Console.ReadLine();

            while (string.IsNullOrEmpty(entrada) || !int.TryParse(entrada, out divisor))
            {
                Console.WriteLine("Errou!!\n\n");
                Console.WriteLine("Entre com o divisor");
                entrada = Console.ReadLine();
            }
            Divisor div = new Divisor();
            div.Divisores(numero, divisor);

            Console.ReadKey();
        }
    }
}
