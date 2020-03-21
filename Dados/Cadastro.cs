using Comum;
using System;

namespace Dados
{

    // ESSE PROJETO É BIBLIOTECA DE CLASSES (.NET CORE)
    public class Cadastro :ICadastro
    { 
        private string Nome { get; set; }
        private string Sobrenome { get; set; }
        private int Idade { get; set; }
        private string Senha { get; set; }

        
        public Cadastro(string nome, string sobrenome, int idade, string senha)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            Senha = senha;

        }

        public string Imprimir()
        {
            return $"{Nome} {Sobrenome} {Idade}";
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetSobrenome()
        {
            return Sobrenome;
        }

        public int GetIdade()
        {
            return Idade;
        }

        public string GetSenha()
        {
            return Senha;
        }
        
    }
}
