using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aula15
{
    class Json3
    {
        /*
        static void Main()
        {
            string arquivo = "Json3.json";
            StreamReader file = File.OpenText(arquivo);

            var dic = JsonConvert.DeserializeObject<Minhaestrutura>(file.ReadToEnd());

            Console.WriteLine(dic.item1);
            Console.WriteLine(dic.item2);
            Console.WriteLine(dic.item2);
            foreach (var item in dic.item4)
            {
                Console.WriteLine("\t" + item);
            }

            file.Dispose();
            file.Close();
        }
        */
    }

    class Minhaestrutura
    {
        public int item1 { get; set; }
        public bool item2 { get; set; }
        public string item3 { get; set; }
        public List<string> item4 { get; set; }
    }
}
