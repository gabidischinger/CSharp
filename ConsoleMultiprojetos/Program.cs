using System;
using System.IO;
using System.Security.Cryptography;
using Comum;
using Dados;
using Negocios;
using Newtonsoft.Json;

namespace ConsoleMultiprojetos
{

    //para ler outro projeto tem que ir em dependência, clicar com botão direito
    //selecionar projeto que projeto deseja ser lido
    //por último incluir o namespace no using

    class Program
    {
        static void Main()
        {
            bool dadosOk;
            string nome, sobrenome;
            int idade = 0;
            string senha;

            Settings settings = new Settings();
            using (StreamReader file = File.OpenText("settings.json"))
            {
                settings = JsonConvert.DeserializeObject<Settings>(file.ReadToEnd());
            }

            do
            {
                Console.WriteLine("Digite seu nome:");
                nome = Console.ReadLine();

                Console.WriteLine("Digite seu sobrenome:");
                sobrenome = Console.ReadLine();

                bool idadeOk;
                do
                {
                    Console.WriteLine("Digite a sua idade:");
                    if (int.TryParse(Console.ReadLine(), out idade))
                        idadeOk = true;
                    else
                    {
                        Console.WriteLine("Idade invalida");
                        idadeOk = false;
                    }
                        

                } while (idadeOk == false);

                Console.WriteLine("Digite a sua senha:");
                senha = Console.ReadLine();

                //Criptografar senha
                Criptografia criptografia = new Criptografia(SHA256.Create());
                string senhaCriptografada = criptografia.CriptografarSenha(senha);

                //Cadastro informacoes
                Cadastro cadastro = new Cadastro(nome, sobrenome, idade, senhaCriptografada);
                ICadastro icadastro = cadastro;

                //Valida informacoes
                AnalisarCadastro analisarCadastro = new AnalisarCadastro();
                string validacao = analisarCadastro.Analisar(icadastro);

                if (string.IsNullOrEmpty(validacao))
                {
                    dadosOk = true;
                    Console.WriteLine(cadastro.Imprimir());
                    Console.WriteLine("Cadastro ok");

                    //Salvar no arquivo
                    ArquivoEPastas.CriarPasta(settings);
                    ArquivoEPastas.CriarEscreverArquivo(settings, senhaCriptografada);
                    Console.WriteLine(ArquivoEPastas.LerArquivo(settings));
                    Console.WriteLine("Arquivo salvo.");

                }
                else
                {
                    dadosOk = false;
                    Console.WriteLine("Cadastro invalido");
                    Console.WriteLine(validacao);
                }




            } while (dadosOk == false);

            ArquivoEPastas.DeletarPasta(settings);
            
            
        }
    }
}
