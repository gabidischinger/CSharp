using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dados
{
    public class ArquivoEPastas
    {
        public static void CriarPasta(Settings settings)
        {
            string pathString = settings.Caminho + settings.Pasta;

            if (!Directory.Exists(pathString))
                Directory.CreateDirectory(pathString);

        }

        public static void CriarEscreverArquivo(Settings settings, string senha)
        {
            string pathString = settings.Caminho + settings.Pasta + settings.Arquivo;

            if (!File.Exists(pathString))
            {
                using (StreamWriter sw = File.CreateText(pathString))
                {
                    sw.WriteLine(senha);
                }

                Console.WriteLine("Senha cadastrados com sucesso");
            }
            else
                Console.WriteLine("Senha já cadastrada");

        }

        public static string LerArquivo(Settings settings)
        {
            string pathString = settings.Caminho + settings.Pasta + settings.Arquivo;

            string senhaUser = "";

            using (StreamReader sr = File.OpenText(pathString))
            {

                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    senhaUser = s;
                }
            }


            return senhaUser;
        }

        public static bool DeletarPasta(Settings settings)
        {
            string pathString = settings.Caminho + settings.Pasta;
            Directory.Delete(pathString, true);

            return true;
        }
    }
}
