using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string entrada;
            Tabuada tab = new Tabuada();

            Console.WriteLine("Fale um número...");
            entrada = Console.ReadLine();

            while (string.IsNullOrEmpty(entrada) || !int.TryParse(entrada, out numero))
            {
                Console.WriteLine("Errou!!\n\n");
                Console.WriteLine("Fale um número...");
                entrada = Console.ReadLine();
            }
            tab.TabuadaDeN(numero);

            Console.ReadKey();
        }
    }
}
