using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool tipo;
            int resultado;
            string continuar;
            Exemplos exe = new Exemplos();

            do
            {
                Console.WriteLine("como deseja converter?\n 1 - ceusiusToFahrenheit\n 2 - FahrenheitToceusius");
                var resposta = Console.ReadLine();
                Console.WriteLine("Entre com a temperatura");
                var graus = Convert.ToInt32(Console.ReadLine());

                tipo = int.TryParse(resposta, out resultado) && resultado == 1 ? true : false;
                exe.ConverterTemperatura(tipo, graus);

                Console.WriteLine("Novamente?\n 1 - Sim\n 2 - Não");
                continuar = Console.ReadLine();

            } while (int.TryParse(continuar, out resultado) && resultado == 1);
            Console.ReadKey();
        }
    }
}
