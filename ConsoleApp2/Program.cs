using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double potencia;
            int resposta;
            string continuar;
            Exemplos exe = new Exemplos();

            do
            {
                Console.WriteLine("Entre com um número.");
                var numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Deseja Exibir o dobro ou elevar a outra potência?\n 1 - Dobro\n 2 - Outra Potência");
                continuar = Console.ReadLine();

                if (int.TryParse(continuar, out resposta) && resposta == 1)
                {
                    exe.Potencia(true, numero, 2);
                }
                else
                {
                    Console.WriteLine("Entre com a potência?");
                    continuar = Console.ReadLine();

                    double.TryParse(continuar, out potencia);

                    exe.Potencia(false, numero, potencia);
                }
                Console.WriteLine("Novamente?\n 1 - Sim\n 2 - Não");
                continuar = Console.ReadLine();

            } while (int.TryParse(continuar, out resposta) && resposta == 1);

            Console.ReadKey();
        }
    }
}
