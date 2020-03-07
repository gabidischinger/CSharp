using System;

namespace Aula13
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("### CARRO ###");
            Carro carro = new Carro();
            carro.Acelerar();
            carro.Ligar();
            carro.Desligar();



            Console.WriteLine();
            Console.WriteLine("### MOTO ###");
            Moto moto = new Moto();
            moto.Acelerar();
            moto.Ligar();
            moto.Desligar();
            moto.Desligar(true);

            int[] a;
            


        }

        void Teste()
        {

        }



    }
}
