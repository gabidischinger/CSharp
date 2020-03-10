using System;
using System.Collections.Generic;
using System.Text;

namespace Aula14
{
    //static void Main(string[] args)
    //{

    //    Passaro passaro = new Passaro();
    //    passaro.BaterAsa();
    //    passaro.Pousar();
    //}

    //classe abstrata é uma superclasse, que tem a base para outras
    //classe abstrata só pode herdar de outras classes abstratas
    //além disso, também não pode ser instanciada
    //classe abstrata é usada para seguir um padrão

    public abstract class Voar
    {
        public void BaterAsa()
        {
            Console.WriteLine("Bater asa da classe voar");
        }

        //método abstract não pode ser definido, implementado
        public abstract bool Pousar();
    }

    public class Passaro : Voar
    {

        //métodos abstratos são obrigados a ser sobrecritos
        public override bool Pousar()
        {
            Console.WriteLine("Pousar da classe passaro");
            return true;
        }
    }
}
