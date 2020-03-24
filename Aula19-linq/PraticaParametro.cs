using System;
using System.Collections.Generic;
using System.Text;

namespace Aula19_linq
{
    class PraticaParametro
    {
        static void Main()
        {

            Console.WriteLine("Digite o primeiro numero:");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            double x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Divisão");
            MetodoPadrao(x1, x2);
            Console.WriteLine();


            Console.WriteLine("Subtrair");
            MetodoPorRef(ref x1, x2);
            Console.WriteLine(x1);
            Console.WriteLine();

            
            Console.WriteLine("Multiplicação");
            MetodoPorOut(x1, x2, out double res);
            Console.WriteLine(res);
            Console.WriteLine();

            Console.WriteLine("Adição");
            MetodoPorParams(x1, x2);
        }

        static void MetodoPadrao(double x1, double x2)
        {
            double res = x1 / x2;
            Console.WriteLine(res);
        }

        static void MetodoPorRef(ref double x1, double x2)
        {
            x1 = x1 - x2;
        }

        static void MetodoPorOut(double x1, double x2, out double r)
        {
            r = x1 * x2;
        }

        static void MetodoPorParams(params object[] e)
        {
            int res= 0;
            foreach (var item in e)
            {
                res = res + Convert.ToInt32(item);
            }

            Console.WriteLine(res);
        }
    }
}
