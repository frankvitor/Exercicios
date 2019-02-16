using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            double valor1, valor2, valor3;
            int operacao, potencia, numero;
            string entrada;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*** Para iniciar a operação basta primeiro digitar um numero\n na sequencia escolher a operação desejada e digitar o próximo valor***\n\n");
            Console.ResetColor();

            Console.WriteLine("1 - Operação Comum\n2 - Potenciação\n3 - Baskara");
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
            else if(int.TryParse(opcao, out operacao) && operacao == 3)
            {
                Console.WriteLine("Baskara");
                Console.WriteLine("Valor A");
                var vlrA = Console.ReadLine();
                double.TryParse(vlrA, out valor1);

                Console.WriteLine("Valor B");
                var vlrB = Console.ReadLine();
                double.TryParse(vlrB, out valor2);

                Console.WriteLine("Valor C");
                var vlrC = Console.ReadLine();
                double.TryParse(vlrC, out valor3);

                calc.Baskara(valor1, valor2, valor3);

            }
            else
            {
                Console.WriteLine("Não foi possível");
            }
            Console.ReadKey();
        }
    }
}
