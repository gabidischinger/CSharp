using System;
using System.Collections.Generic;
using System.Text;

namespace Aula13
{
    public class Carro
    {

        public void Acelerar()
        {
            Console.WriteLine("Acelerar carro");
        }

        public virtual void Ligar()
        {
            Console.WriteLine("Ligar carro");
        }

        public void Desligar()
        {
            Console.WriteLine("Desligar carro");
        }

    }
}
