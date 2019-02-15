using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            double valor1, valor2;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*** Para iniciar a operação basta primeiro digitar um numero\n na sequencia escolher a operação desejada e digitar o próximo valor***\n\n");
            Console.ResetColor();

            Console.WriteLine("");
            var vlr1 = Console.ReadLine();
            double.TryParse(vlr1, out valor1);

            Console.WriteLine(" +\n -\n /\n *");
            var entrada = Console.ReadLine();

            Console.WriteLine("");
            var vlr2 = Console.ReadLine();
            double.TryParse(vlr2, out valor2);

            if (entrada.Equals("+"))
            {
                calc.Somar(valor1, valor2);
            }
            else if (entrada.Equals("-"))
            {
                calc.Subtrair(valor1, valor2);
            }
            else if (entrada.Equals("/"))
            {
                calc.Dividir(valor1, valor2);
            }
            else
            {
                calc.Multiplicar(valor1, valor2);
            }



            Console.ReadKey();
        }
    }
}
