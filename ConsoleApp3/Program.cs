using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {


            var count = 0;
            string nota;
            List<double> notas = new List<double>();

            Console.WriteLine("Calcular Média do Aluno?");
            Console.WriteLine("Nome do aluno?");
            var nome = Console.ReadLine();
            Console.WriteLine("Quantas notas pretende adicionar?");
            var qtdNotas = Convert.ToInt32(Console.ReadLine());

            Aluno exe = new Aluno();
            while (qtdNotas != count)
            {
                Console.WriteLine($"Nota {count + 1}?");
                nota = Console.ReadLine();

                double.TryParse(nota, out double resposta);

                notas.Add(resposta);
                count++;
            }
            exe.CalculaMedia(notas, qtdNotas, nome);

            Console.ReadKey();
        }
    }
}
