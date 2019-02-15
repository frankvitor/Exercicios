using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            double valor1, valor2;
            int operacao, potencia, numero;
            string entrada;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*** Para iniciar a operação basta primeiro digitar um numero\n na sequencia escolher a operação desejada e digitar o próximo valor***\n\n");
            Console.ResetColor();

            Console.WriteLine("1 - Operação Comum\n2 - Potenciação");
            var opcao = Console.ReadLine();

            if (int.TryParse(opcao, out operacao) && operacao == 2)
            {
                Console.WriteLine("Numero");
                entrada = Console.ReadLine();
                int.TryParse(entrada, out numero);

                Console.WriteLine($"{entrada} Elevado à");
                entrada = Console.ReadLine();
                int.TryParse(entrada, out potencia);

                calc.Potencia(numero, potencia);
            }
            else if (int.TryParse(opcao, out operacao) && operacao == 1)
            {
                Console.WriteLine("Calculadora Comum");
                Console.WriteLine("Numero");
                var vlr1 = Console.ReadLine();
                double.TryParse(vlr1, out valor1);

                Console.WriteLine(" +\n -\n /\n *");
                entrada = Console.ReadLine();

                Console.WriteLine($"{vlr1} {entrada} ");
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
            }
            Console.ReadKey();
        }
    }
}
