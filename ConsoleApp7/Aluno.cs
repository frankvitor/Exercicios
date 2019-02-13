using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    public class Aluno
    {
        #region ▪ Properties ▪

        public string Matricula { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Curso { get; private set; }
        public string Telefone { get; private set; }
        public string Endereco { get; private set; }

        #endregion ▪ Properties ▪

        List<Aluno> alunos = new List<Aluno>();

        public Aluno()
        {

        }
        public Aluno(string matricula, string nome, string email, string curso, string telefone, string endereco)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.Email = email;
            this.Curso = curso;
            this.Telefone = telefone;
            this.Endereco = endereco;
        }
        public void AdicionarAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }
        public void ListarAlunos()
        {
            //alunos.ForEach(Console.WriteLine);
            foreach (var elemento in alunos)
            {
                Console.WriteLine(elemento.Nome);
                Console.WriteLine(elemento.Matricula);
            }
        }
    }
}
