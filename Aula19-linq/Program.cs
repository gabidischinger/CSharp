using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula19_linq
{
    class Program
    {
        //static void Main()
        //{
        //    List<Alunos> alunos = new List<Alunos>()
        //    {
        //        new Alunos("J", 13, 9.5, false),
        //        new Alunos("B", 12, 9.2, false),
        //        new Alunos("C", 13, 9.7, false),
        //        new Alunos("G", 12, 9.9, true),
        //        new Alunos("E", 14, 8, false),
        //        new Alunos("F", 14, 7, false),
        //        new Alunos("D", 13, 5.1, false),
        //        new Alunos("H", 13, 6.1, true),
        //        new Alunos("I", 11, 7, true),
        //        new Alunos("A", 12, 5, false),
        //    };

        //    var totalImigrantes = alunos.Where(a => a.Imigrante == true);
        //    Console.WriteLine($"Total de alunos imigrantes: {totalImigrantes.Count()}");

        //    var mediaMaiorQue9 = alunos.Where(a => a.Media > 9);
        //    Console.WriteLine($"Total de alunos com média acima de 9: {mediaMaiorQue9.Count()}");

        //    var idade12mediaMaiorQue8 = alunos.Where(a => a.Idade == 12 && a.Media > 8);
        //    Console.WriteLine($"Total de alunos com 12 anos com média maior que 8: {idade12mediaMaiorQue8.Count()}");

        //    Console.WriteLine();

        //    Console.WriteLine("Alunos em ordem alfabetica");
        //    var alfabetico = alunos.OrderBy(a => a.Nome);

        //    foreach (var item in alfabetico)
        //    {
        //        Console.Write($"{item.Nome} ");
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine();

        //    Console.WriteLine("Alunos em ordem decrescente de idade e após alfabetica por nome");
        //    var idadeAlfabetico = alunos.OrderByDescending(a => a.Idade).ThenBy(a => a.Nome);

        //    foreach (var item in idadeAlfabetico)
        //    {
        //        Console.Write($"{item.Nome} ");
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine();

        //    Console.WriteLine("Lista de alunos por ordem crescente de media, depois de ordem alfabetica de nome e não imigrantes");
        //    var mediaAlfabeticaImigrantes = alunos.OrderBy(a => a.Media).ThenBy(a => a.Nome).Where(a => a.Imigrante == false);

        //    foreach (var item in mediaAlfabeticaImigrantes)
        //    {
        //        Console.Write($"{item.Nome} ");
        //    }

        //}
    }

    public class Alunos
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Media { get; set; }
        public bool Imigrante { get; set; }

        public Alunos(string nome, int idade, double media, bool imigrante)
        {
            Nome = nome;
            Idade = idade;
            Media = media;
            Imigrante = imigrante;
        }
    }
}
