using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Aulas
{
    class _Aula6
    {
        //static void Main()
        //{
        //    //Cachorro cachorro = new Cachorro("June", new DateTime(2012, 06, 12));

        //    //Gato gato = new Gato();
        //    //gato.Nome = "Cleo";
        //    //gato.Nascimento = new DateTime(2015, 10, 20);

        //    Cachorro2 cachorro2 = new Cachorro2("June", new DateTime (2012, 06, 12));

        //    Impressao.ImprimirCachorro(cachorro2);
        //    ImpressaoAnimal.ImprimirAnimal(cachorro2);

        //    cachorro2.Latir();
        //    cachorro2.Passear();

        //    Animal animal1 = new Cachorro2("Titi", new DateTime(2012, 04, 10));
        //    //dessa forma, ele não pega os métodos de Gato


        //    //Impressao.ImprimirGato(gato);
        //    //gato.Miar();
        //    //gato.Passear();

        //}


        // PRIMEIRA SOLUÇÃO - MAIS SIMPLES, SEM CONSTRUTORES -----------------------------------------------------
        //public class Cachorro
        //{
        //    public string Nome { get; set; }
        //    public DateTime Nascimento { get; set; }

        //public cachorro(string nome, datetime data)
        //{
        //    nome = nome;
        //    nascimento = data;
        //}

        //    public void Latir()
        //    {
        //        Console.WriteLine("Au au");
        //    }

        //    public void Passear()
        //    {
        //        Console.WriteLine("Passear cachorro");
        //    }


        //}

        //public class Gato
        //{
        //    public string Nome { get; set; }
        //    public DateTime Nascimento { get; set; }

        //    //public Gato(string nome, string data)
        //    //{
        //    //    Nome = nome;
        //    //    Nascimento = data;
        //    //}

        //    public void Miar()
        //    {
        //        Console.WriteLine("Miau miau");
        //    }

        //    public void Passear()
        //    {
        //        Console.WriteLine("Passear gato");
        //    }
        //}

        public static class Impressao
        {
            public static void ImprimirCachorro(Cachorro2 c)
            {
                Console.WriteLine("CACHORRO:");
                Console.WriteLine($"Nome: {c.Nome}");
                Console.WriteLine($"Nascimento: {c.Nascimento}");
            }

            public static void ImprimirGato(Gato1 g)
            {
                Console.WriteLine("GATO");
                Console.WriteLine($"Nome: {g.Nome}");
                Console.WriteLine($"Nascimento: {g.Nascimento}");
            }
        }

        // SEGUNDA SOLUÇÃO - UNINDO O QUE HÁ IGUAL EM UMA CLASSE E DEIXANDO UMA DAS VARIÁVEIS COMO READONLY ----------------------------------------
        public class Animal
        {
            public string Nome { get; }
            public DateTime Nascimento { get; set; }

            public Animal(string nome, DateTime data)
            {
                Nome = nome;
                Nascimento = data;
            }

            public void Passear()
            {
                Console.WriteLine("Passear cachorro");
            }
        }


        //public class Cachorro1 : Animal
        //{

        //    public Cachorro1(string nome, DateTime data) : base(nome, data)
        //    {

        //    }
        //    public void Latir()
        //    {
        //        Console.WriteLine("Au au");
        //    }
        //}

        public class Cachorro2 : Animal
        {
            
            public Cachorro2(string nome, DateTime data) : base(nome, data)
            {

            }
            public void Latir()
            {
                Console.WriteLine("Au au");
            }
        }

        public class Gato1 : Animal
        {
            public Gato1(string nome, DateTime data) : base(nome, data)
            {

            }
            public void Miar()
            {
                Console.WriteLine("Miau miau");
            }
        }

        //static class - não pode criar novos dela
        static class ImpressaoAnimal
        {
            public static void ImprimirAnimal(Animal a)
            {
                string especie = a.GetType().Name;
                Console.WriteLine($"Especie: {especie}");
                Console.WriteLine($"Nome: {a.Nome}");
                Console.WriteLine($"Nascimento: {a.Nascimento}");
            }
        }
    }
}
