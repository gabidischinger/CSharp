using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Aulas
{
    class Principal
    {
        static void Main()
        {
            Console.WriteLine("Iniciando o programa");
            Console.WriteLine("Digite um valor: ");

            // string stg = Console.ReadLine();

            // Console.WriteLine(stg);

            //variáveis simples
            string texto = "Olá";
            int numero = 100;
            long numeroL = 100;
            bool ok = true;
            char letra = 'a';
            double valor = 1.123;
            decimal dinheiro = 1.123M;
            float valorf = 1.123F;


            /*
            Console.WriteLine("Minha impressão: " + texto);
            Console.WriteLine("Minha impressão: " + numero);
            Console.WriteLine("Minha impressão: " + numeroL);
            Console.WriteLine("Minha impressão: " + ok);
            Console.WriteLine("Minha impressão: " + letra);
            Console.WriteLine("Minha impressão: " + valor);
            Console.WriteLine("Minha impressão: " + dinheiro);
            Console.WriteLine("Minha impressão: " + valorf);
            */

            //Concatenacao de string
            string texto2 = "Gabriela";
            string concatenado = texto + " / " + texto2;

            Console.WriteLine(concatenado);

            //Soma
            int num1 = 100;
            int num2 = 50;
            int result = num1 + num2;

            Console.WriteLine(result);

            //Converter numero para string
            string convert = Convert.ToString(num1);
            Console.WriteLine(convert);
            Console.WriteLine(num1.ToString() + num2.ToString());

            //Conversao string para inteiro
            string num3 = "1";
            string num4 = "2";
            int resultado = Convert.ToInt16(num3) + Convert.ToInt16(num4);
            int resultsoma = Convert.ToInt16(num3 + num4);
            Console.WriteLine(resultado);
            Console.WriteLine(resultsoma);

            double valor1 = 1.5001;
            double valor2 = 1.123123123;
            double valorInt = 1;
            double resultvalores = valor1 + valor2;
            double resultcomInt = valor1 + valor2 + valorInt;
            Console.WriteLine(resultvalores);
            Console.WriteLine(resultcomInt);
            //Double só não conversa com Decimal, mas é possível soma-lo com int e float

            //definir a moeda - variável do tipo complexa
            CultureInfo culture = new CultureInfo("en-US");

            Console.WriteLine("Resultado convertendo: " + resultcomInt.ToString("F2"));
            //Para aparecer moeda:
            Console.WriteLine("Resultado convertendo: " + resultcomInt.ToString("C2", culture));

            //A variável cultura também afeta data
            DateTime date = DateTime.Now;
            Console.WriteLine("Horário atual: " + date);


            DateTime datemanual = new DateTime(2020, 02, 05, 20, 20, 20);


            Console.WriteLine("Horário atual: " + datemanual.ToString(culture));
            Console.WriteLine("Horário long: " + datemanual.ToLongDateString());
            Console.WriteLine("Horário short: " + datemanual.ToShortDateString());

            //manipular datas
            DateTime dateadd = DateTime.Now.AddDays(7);
            Console.WriteLine("Mais 7 dias: " + dateadd);

            double num5 = 10;

            double pot = Math.Pow(num5, 2);
            double raiz = Math.Sqrt(num5);
            double raizcub = Math.Cbrt(num5);
            double max = Math.Max(1, 100);
            double min = Math.Min(1, 100);
            double round = Math.Round(1.2324324, 2);


            Console.WriteLine(pot);
            Console.WriteLine(raiz);
            Console.WriteLine(raizcub);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(round);
        }
    }
}
