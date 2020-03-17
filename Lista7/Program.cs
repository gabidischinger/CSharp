using Newtonsoft.Json;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Text;


namespace Lista7
{
    class Program
    {
        static void Main()
        {
            Settings settings = new Settings();
            using (StreamReader file = File.OpenText("settings.json"))
            {
                settings = JsonConvert.DeserializeObject<Settings>(file.ReadToEnd());
            }

            int opcao = 0;

            do
            {
                Console.WriteLine("Escolha a opcao desejada:");
                Console.WriteLine("1 - Configurar usuário e senha");
                Console.WriteLine("2 - Logar");
                Console.WriteLine("3 - Limpar base");
                Console.WriteLine("4 - Sair");

                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                }

                switch (opcao)
                {
                    case 1:
                        CadastrarSenha(settings);
                        break;
                    case 2:
                        Logar(settings);
                        break;
                    case 3:
                        LimparBase(settings);
                        break;
                    case 4:
                        Console.WriteLine("Saindo");
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }

            } while (opcao != 4);
        }

        private static void CadastrarSenha(Settings settings)
        {
            ArquivosEPastas.CriarPasta(settings);

            Console.WriteLine("Digite o usuário:");
            string usuario = Console.ReadLine();

            Console.WriteLine("Digite a senha:");
            string senha = Console.ReadLine();
            
            Criptografia criptografia = new Criptografia();
            string senhaCriptografada = criptografia.CriptografarSenha(SHA256.Create(), senha);

            ArquivosEPastas.CriarEscreverArquivo(settings, usuario, senhaCriptografada);

        }

        private static void Logar(Settings settings)
        {

            string pathBD = settings.Caminho + settings.Pasta + settings.Arquivo;

            if (File.Exists(pathBD))
            {
                Console.WriteLine("Digite o usuário:");
                string usuarioDigitado = Console.ReadLine();

                Console.WriteLine("Digite a senha:");
                string senhaDigitada = Console.ReadLine();



                List<string> dadosUsuario = ArquivosEPastas.LerArquivo(settings);
                string usuarioCadastrado = dadosUsuario[0];
                string senhaCadastrada = dadosUsuario[1];


                Criptografia criptografia = new Criptografia();
                bool validaSenha = criptografia.ValidarSenha(SHA256.Create(), senhaDigitada, senhaCadastrada);

                bool verificaUsuario = false;
                if (usuarioDigitado == usuarioCadastrado)
                    verificaUsuario = true;


                if (validaSenha && verificaUsuario)
                    Console.WriteLine("Login realizado com sucesso!");
                else
                    Console.WriteLine("Usuário ou senha inválidos");
            }
            else
                Console.WriteLine("Nenhum usuário cadastrado");

            
        }

        private static void LimparBase(Settings settings)
        {

            if (ArquivosEPastas.DeletarPasta(settings))
                Console.WriteLine("Base deletada com sucesso");
            else
                Console.WriteLine("Não há nenhum usuário cadastrado");

        }

    }
}
