using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int resposta;
            Console.WriteLine("Alunos");
            Console.WriteLine("O que deseja fazer?\n 1 - Cadastrar Aluno\n 2 - Listar Alunos");
            entrada = Console.ReadLine();

            while(string.IsNullOrEmpty(entrada) || !int.TryParse(entrada, out resposta))
            {
                Console.WriteLine("Nao entendi.");
                Console.WriteLine("O que deseja fazer?\n 1 - Cadastrar Aluno\n 2 - Listar Alunos");
                entrada = Console.ReadLine();
            }
            if (resposta == 1)
            {
                Console.WriteLine("Numero matricula.");
                var matricula = Console.ReadLine();
                Console.WriteLine("Nome.");
                var nome = Console.ReadLine();
                Console.WriteLine("Email.");
                var email = Console.ReadLine();
                Console.WriteLine("Curso.");
                var curso = Console.ReadLine();
                Console.WriteLine("Telefone.");
                var telefone = Console.ReadLine();
                Console.WriteLine("Endereço.");
                var endereco = Console.ReadLine();

                Aluno a2 = new Aluno(matricula, nome, email, curso, telefone, endereco);
                a2.AdicionarAluno(a2);
                a2.ListarAlunos();

            }

            Console.ReadKey();
        }
    }
}
