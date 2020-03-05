using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Aulas.Aula6___Herança
{
    class Animal
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
            Console.WriteLine("Passeando");
        }
    }
}
