using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lista7
{
    class ArquivosEPastas
    {
        public static void CriarPasta(Settings settings)
        {
            string pathString = settings.Caminho + settings.Pasta;

            if (!Directory.Exists(pathString))
                Directory.CreateDirectory(pathString);

        }

        public static void CriarEscreverArquivo(Settings settings, string usuario, string senha)
        {
            string pathString = settings.Caminho + settings.Pasta + settings.Arquivo;

            if (!File.Exists(pathString))
            {
                using (StreamWriter sw = File.CreateText(pathString))
                {
                    
                    sw.WriteLine(usuario);
                    sw.WriteLine(senha);

                }

                Console.WriteLine("Usuário e senha cadastrados com sucesso");
            }
            else
                Console.WriteLine("Senha já cadastrada");

        }

        public static List<string> LerArquivo(Settings settings)
        {
            string pathString = settings.Caminho + settings.Pasta + settings.Arquivo;

            List<string> dadosUsuario = new List<string>();

            using (StreamReader sr = File.OpenText(pathString))
            {
                                
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    dadosUsuario.Add(s);
                }
            }


            return dadosUsuario;
        }

        public static bool DeletarPasta(Settings settings)
        {
            string pathString = settings.Caminho + settings.Pasta;
            Directory.Delete(pathString, true);

            return true;
        }
    }
}
