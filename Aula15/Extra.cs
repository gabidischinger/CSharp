using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace Aula15
{
    class Extra
    {
        /*
        static void Main(string[] args)
        {
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}\n", drive);

            Console.WriteLine("SO: {0}\n", Environment.OSVersion);
            Console.WriteLine("Processos: {0}\n", Environment.ProcessorCount);
            Console.WriteLine("Versao .NET: {0}\n", Environment.Version);
            Console.WriteLine("Diretorio corrente: {0}\n", Environment.CurrentDirectory);
            Console.WriteLine("Diretorio sistema: {0}\n", Environment.SystemDirectory);
            Console.WriteLine("Nome maquina: {0}\n", Environment.MachineName);
            Console.WriteLine("Usuario: {0}\n", Environment.UserName);
            Console.WriteLine("Dominio: {0}\n", Environment.UserDomainName);

            int days = (int)Environment.TickCount / (1000 * 60 * 60 * 24);
            int hours = (Environment.TickCount % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60);
            int minutes = (Environment.TickCount % (1000 * 60 * 60)) / (1000 * 60);
            int seconds = (Environment.TickCount % (1000 * 60)) / 1000;
            int milliseconds = Environment.TickCount % (1000);

            Console.WriteLine("Computador ligado ha {0} dias, {1} horas, {2} minutos, {3} segundos and {4} ms\n", days, hours, minutes, seconds, milliseconds);

            Console.Read();

            var number = new Random();
            var n = number.Next();
            var nn = number.Next(0, 100);

            var id = new Guid("{00000000-0000-0000-0000-000000000000}");

            DateTime now = DateTime.Now;
            Console.WriteLine("ToString()-- > {0}", now.ToString());
            Console.WriteLine("ToLocalTime()-- > {0}", now.ToLocalTime());
            Console.WriteLine("ToUniversalTime()-- > {0}", now.ToUniversalTime());
            Console.WriteLine("ToShortDateString()-- > {0}", now.ToShortDateString());
            Console.WriteLine("ToShortTimeString()-- > {0}", now.ToShortTimeString());
            Console.WriteLine("ToLongDateString()-- > {0}", now.ToLongDateString());
            Console.WriteLine("ToLongTimeString()-- > {0}", now.ToLongTimeString());

            Console.Read();

        }
        */

        
        static void Main()
        {

            string a = "hello world!";
            string b = "iai rocks!";

            //Console.WriteLine("{0} is {1} chars long", a, a.Length);
            //Console.WriteLine("{0} is {1} chars long", b, b.Length);
            //Console.WriteLine("{0} == {1} is {2}", a, b, a.CompareTo(b) == 0);

            ////Concatenation
            //string c = a + " --> " + b;
            //Console.WriteLine("c = a + \"-- > \" +b gives {0}", c);

            //int numWords = 4;
            //string e = "There are " + numWords + " words.";

            ////string literals
            //string code = @"int numWords = 4";
            //string ee = "There are " + numWords;
            //Console.WriteLine("{0} --->gives: {1}", code, ee);

            ////Padding
            //Console.WriteLine("Right aligned(PadLeft):\n {0}\n{1} \n", a.PadLeft(30), b.PadLeft(30));
            //Console.WriteLine("Left aligned(PadRight):\n {0}\n{1} \n", a.PadRight(30, '.'), b.PadRight(30, '.'));

            ////Remove
            //string d = "These are four words";
            //Console.WriteLine("I have removed a word from \"{0}\",getting \"{1}\"", d, d.Remove(5, 4));

            ////Replace
            //string f = " a b c a b c a b c abcabcabc";
            //Console.WriteLine("string f = \" a b c a b c a b c abcabcabc\";\n f.Replace(‘a’,’x’)---> \"{0}\"", f.Replace('a', 'x'));

            //Console.WriteLine("string f = \" a b c a b c a b c abcabcabc\";\n f.Replace(\"abc\", \"xyz\")---> \"{0}\"", f.Replace("abc", "xyz"));

            ////Tokens and splitting
            //string g = "There are some words in a single string.\n We now want to break them up into strings, one word each, removing the spaces.";

            //string[] separators = new string[] { " ", "\n" };
            //string[] tokens = g.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //Console.WriteLine("Now splitting the string\n\"{0}\"\n into words...", g);
            //for (int i = 0; i < tokens.Length; i++)
            //{
            //    Console.WriteLine("token[{0}] = {1}", i, tokens[i]);
            //}

            ////insertion
            //string h = "Insert in here";
            //Console.WriteLine("Insertion demo. Inserting a string into \n * **{0} ***\n * **{1} ***", h, h.Insert(6, "ed a word"));

            // String builder
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\nIniciei aqui");
            stringBuilder.Append("\nMinha \"string builder\".");
            stringBuilder.Insert(1, "Ola, ");
            stringBuilder.Remove(14, 4);
            Console.WriteLine(stringBuilder);


            Console.ReadLine();
        }
        
        
    }
}
