using System;
using System.Collections.Generic;
using System.Text;

namespace Aula19_linq
{
    class PasagemParametro
    {
        //static void Main()
        //{
        //    Console.WriteLine("Passagem padrão");
        //    int x = 100;
        //    MetodoPadrao(x);
        //    Console.WriteLine(x);
        //    Console.WriteLine();


        //    //Metodo por referência atualiza o valor da  - usado para enriquecimento de variável
        //    //só faz sentido quando quero passar alguma variável e receber ela própria atualizada, não utilizar quando for para retornar outra coisa
        //    Console.WriteLine("Passagem por ref");
        //    int y = 200;
        //    MetodoPorRef(ref y);
        //    Console.WriteLine(y);
        //    Console.WriteLine();

        //    //Forma de retornar parametro, sem alterar o void, sem precisar usar return
        //    Console.WriteLine("Passaem por out");
        //    int z = 300;
        //    MetodoPorOut(z, out int res);
        //    Console.WriteLine(res);
        //    Console.WriteLine();

        //    Console.WriteLine("Passaem por params");
        //    int w1 = 400;
        //    string w2 = "Prop=";
        //    MetodoPorParams(w1, w2);

        //}

        static void MetodoPadrao(int xx)
        {
            xx++;
            Console.WriteLine(xx);
        }

        static void MetodoPorRef(ref int yy)
        {
            yy++;
        }

        static void MetodoPorOut(int zz, out int r)
        {
            r = ++zz;
        }

        static void MetodoPorParams(params object[] e)
        {
            foreach (var item in e)
            {
                Console.WriteLine(item);
            }
        }
    }
}
