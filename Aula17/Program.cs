using System;

namespace Aula17
{
    class Program
    {
        static void Main()
        {
            Passaro oPassaro = new Passaro();
            oPassaro.Bicar();
            Console.WriteLine(oPassaro.BaterAsas());

            Peixe oPeixe = new Peixe();
            oPeixe.BeberAgua();
            oPeixe.MexerNadadeiras();

            Mutacao oMutacao = new Mutacao();
            Console.WriteLine(oMutacao.BaterAsas());
            oMutacao.BebendoAgua();
            oMutacao.MexerNadadeiras();

            //obj só vai ter o que os métodos definidos na interface
            //mas sempre é necessário passar a instância da classe concreta
            //passa a ser restrição por interface
            IVoar voar = new Passaro();
            Console.WriteLine(voar.BaterAsas());

            INadar nadar = new Peixe();
            nadar.MexerNadadeiras();

            INadar nadarMut = new Mutacao();
            nadarMut.MexerNadadeiras();

            IVoar voarMut = new Mutacao();
            Console.WriteLine(voarMut.BaterAsas());
            
        }
    }

    class Passaro : IVoar
    {
        public string BaterAsas()
        {
            return "Batendo asas!";
        }

        public void Bicar()
        {
            Console.WriteLine("Bicando!");
        }

    }

    class Peixe : INadar
    {
        
        public void BeberAgua()
        {
            Console.WriteLine("Bebendo água!");
        }

        public void MexerNadadeiras()
        {
            Console.WriteLine("Nadando!");
        }
    }

    class Mutacao : IVoar, INadar
    {
        public string BaterAsas()
        {
            return "Peixe voador!";
        }

        public void MexerNadadeiras()
        {
            Console.WriteLine("Peixe voador nadando");
        }

        public void BebendoAgua()
        {
            Console.WriteLine("Bebendo água");
        }
    }
}
