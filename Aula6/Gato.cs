using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Aulas.Aula6___Herança
{
    class Gato : Animal
    {
        public Gato(string nome, DateTime data) : base(nome, data)
        {

        }
        public void Miar()
        {
            Console.WriteLine("Miau miau");
        }
    }
}
