using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Aula14
{
    class Program
    {
        static void Main()
        {
          
            string senha = ConfigurationManager.AppSettings["Senha"];


            JObject json = JObject.Parse(File.ReadAllText(@"D:\OneDrive\Estudos\Pi\Repositorio\CSharp\Aula14\myfile.json"));
            Console.WriteLine(json);
            Console.WriteLine();
            Console.WriteLine();

            Dictionary<string, string> lst2;

            using (StreamReader file = File.OpenText(@"D:\OneDrive\Estudos\Pi\Repositorio\CSharp\Aula14\myfile.json"))
            {
                lst2 = JsonConvert.DeserializeObject<Dictionary<string, string>>(file.ReadToEnd());
                foreach (var item in lst2)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }

                //var lst1 = JsonConvert.DeserializeObject<dynamic>(file.ReadToEnd());
                //foreach (KeyValuePair<string, object> item in lst1)
                //{
                //    Console.WriteLine($"{item.Key}: {item.Value}");
                //}

            }
            Console.WriteLine();
            Console.WriteLine();

            Criptografia criptografia = new Criptografia();
            string senhaCriptografada = criptografia.CriptografarSenha(SHA256.Create(), senha);
            Console.WriteLine($"Senha criptografa: {senhaCriptografada}");


            //Console.WriteLine("Digite a sua senha:");
            //string senhaDigitada = Console.ReadLine();
            string senhaDigitada = lst2["senhaDigitada"];

            bool verificaSenha = criptografia.VerificarSenha(SHA256.Create(), senhaDigitada, senhaCriptografada);
            

            if (verificaSenha)
                Console.WriteLine("Senha correta!");
            else
                Console.WriteLine("Senha inválida");


            

        }
    }

    class Criptografia
    {
        public string CriptografarSenha(HashAlgorithm _algoritmo, string senha)
        {
            var encodedValue = Encoding.UTF8.GetBytes(senha);
            var encryptedPassword = _algoritmo.ComputeHash(encodedValue);
            var sb = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                sb.Append(caracter.ToString("X2"));
            }
            return sb.ToString();
        }
        public bool VerificarSenha(HashAlgorithm _algoritmo, string senhaDigitada, string senhaCadastrada)
        {
            if (string.IsNullOrEmpty(senhaCadastrada))
                throw new NullReferenceException("Cadastre uma senha.");
            var encryptedPassword = _algoritmo.ComputeHash(Encoding.UTF8.GetBytes(senhaDigitada));
            var sb = new StringBuilder();
            foreach (var caractere in encryptedPassword)
            {
                sb.Append(caractere.ToString("X2"));
            }
            return sb.ToString() == senhaCadastrada;
        }
    }
}
