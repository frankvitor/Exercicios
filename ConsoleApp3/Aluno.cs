using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public class Aluno
    {
        public string Nome { get;private set; }
        List<double> Notas = new List<double>();
        public void CalculaMedia(List<double> notas, int qtdNotas, string aluno)
        {
            Notas = notas;
            double total = Notas.Sum() / qtdNotas;
            if (total >= 7.5)
                Console.WriteLine($"O Aluno {aluno} ficou com {total} de média. e foi APROVADO!!!");

            else if (total <= 4.0)
                Console.WriteLine($"O Aluno {aluno} ficou com {total} de média. E foi REPROVADO!!!");

            else
                Console.WriteLine($"O Aluno {aluno} ficou com {total} de média. E ficou de EXAME!!!");
        }
    }
}
