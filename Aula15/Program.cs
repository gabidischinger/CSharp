using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace Aula15
{
    class Program
    {
        /*
        static void Main()
        {
            //caminho para o arquivo
            //quando está na mesma pasta (como no exemplo), basta ser o nome
            //string arquivo = "D:/OneDrive/Estudos/Pi/Repositorio/CSharp/Aula15/myfile.json";
            //para não precisar falar o caminho completo, clicar com botão direito no arquivo json, propriedades e alterar copiar para diretório para sempre
            string arquivo = "myfile.json";

            //abrir o arquivo
            StreamReader file = File.OpenText(arquivo);
            //var dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(file.ReadToEnd());
            //é possível usar dynamic dentro do dicionário - dessa forma ele aceita qualquer tipo de variável

            //var dic = JsonConvert.DeserializeObject<List<string>>(file.ReadToEnd());

            var dic = JsonConvert.DeserializeObject<MinhaEstrutura>(file.ReadToEnd());

            Console.WriteLine(dic.prop1);
            Console.WriteLine(dic.prop2);
            Console.WriteLine(dic.prop3);
            Console.WriteLine(dic.prop4);
            Console.WriteLine(dic.prop5);

            
            foreach (var item in dic.prop3)
            {
                Console.WriteLine($"{item}");
            }
            

        }
        */
    }




    class MinhaEstrutura
    {
        public int prop1 { get; set; }
        public int prop2 { get; set; }
        public List<string> prop3 { get; set; }
        public bool prop4 { get; set; }
        public string prop5 { get; set; }
    }

    class MinhaEstrutura2
    {

    }
}
