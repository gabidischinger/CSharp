using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Aulas.Aula6___Herança
{
    static class Impressao
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
