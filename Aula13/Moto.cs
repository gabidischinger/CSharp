using System;
using System.Collections.Generic;
using System.Text;

namespace Aula13
{
    class Moto : Carro
    {
        public new void Acelerar()
        {
            Console.WriteLine("Acelerar moto.");
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligar moto");
        }

        public void Desligar(bool d)
        {
            Console.WriteLine("Desligar moto: " + d);
        }
    }
}
