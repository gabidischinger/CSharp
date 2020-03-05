using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Exercícios.ListaExers5
{
    class Exer2_Dicionario
    {
        public static void CriarDicionario()
        {
            Dictionary<string, string> sites = new Dictionary<string, string>();

            AdicionarSites(sites);
            BuscarSites(sites);
        }

        private static void BuscarSites(Dictionary<string, string> sites)
        {
            int opcao = 0;

            do
            {

                Console.WriteLine();
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("1 - Achar um site");
                Console.WriteLine("2 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());


                if (opcao == 1)
                {
                    Console.WriteLine("Digite o nome do site desejado:");
                    string busca = Console.ReadLine();

                    if (sites.TryGetValue(busca, out string nome))
                        Console.WriteLine("URL do site buscado: " + nome);

                }
            } while (opcao != 2);
        }

        private static void AdicionarSites(Dictionary<string, string> sites)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o nome do site:");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a url do site:");
                string url = Console.ReadLine();

                sites.Add(nome, url);
            }
        }
    }
}
