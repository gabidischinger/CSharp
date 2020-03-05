using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Exercícios
{
    class ListaExers3
    {
        static void Main()
        {
            Alunos aluno1 = new Alunos("Gabriela", Guid.NewGuid().ToString(), 5.5, 9, "Reprovado");
            aluno1.Imprimir();

            aluno1.CorrigirNome("Gabriela Miranda");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Antes:\n");
            aluno1.Imprimir();

            aluno1.Status = StatusAluno.CorrigirStatus(aluno1.Nota1, aluno1.Nota2);

            Console.WriteLine();
            Console.WriteLine("Depois:\n");
            aluno1.Imprimir();

            //StatusAluno.peso1 = 2;
            Console.WriteLine();
            Console.WriteLine("Erro que aparece ao tentar atualizar um atributo tipo const: CS0131  O lado esquerdo de uma atribuição deve ser uma variável, uma propriedade ou um indexador");

            //aluno1.Id = "2";
            Console.WriteLine();
            Console.WriteLine("Erro que aparece ao tentar atualizar um atributo do tipo readonly: CS0191	Um campo somente leitura não pode ser atribuído (exceto em um construtor ou inicializador de variável)");

        }
    }

    public class Alunos
    {
        private string Nome { get; set; }
        public readonly string Id;
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public string Status { get; set; }

        public Alunos (string nome, string id, double nota1, double nota2, string status)
        {
            Nome = nome;
            Id = id;
            Nota1 = nota1;
            Nota2 = nota2;
            Status = status;
        }

        public void CorrigirNome(string nome)
        {
            Nome = nome;
        }

        public void Imprimir()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Dados do aluno:");
            str.Append($"\nNome: {Nome}");
            str.Append($"\nID: {Id}");
            str.Append($"\nNota 1: {Nota1}");
            str.Append($"\nNota 2: {Nota2}");
            str.Append($"\nStatus: {Status}");

            Console.WriteLine(str);
        }
    }

    static class StatusAluno
    {
        public const double peso1 = 1;
        public const double peso2 = 2;

        public static string CorrigirStatus(double nota1, double nota2)
        {
            double media = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);
            if (media >= 7)
                return "Aprovado";
            else
                return "Reprovado";
        }

    }
}
