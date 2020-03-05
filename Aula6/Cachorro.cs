using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Aulas.Aula6___Herança
{
    class Cachorro : Animal
    {
        public Cachorro(string nome, DateTime data) : base(nome, data)
        {

        }
        public void Latir()
        {
            Console.WriteLine("Au au");
        }
    }
}
