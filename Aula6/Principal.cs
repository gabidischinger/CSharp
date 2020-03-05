using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Aulas.Aula6___Herança
{
    class Principal
    {
        static void Main()
        {

            Cachorro cachorro = new Cachorro("June", new DateTime(2012, 06, 12));

            Impressao.ImprimirAnimal(cachorro);
            cachorro.Latir();
            cachorro.Passear();

            Gato gato = new Gato("Agata", new DateTime(2017, 10, 15));
            Impressao.ImprimirAnimal(gato);
            gato.Miar();
            gato.Passear();

            Console.Read();


        }
    }
}
