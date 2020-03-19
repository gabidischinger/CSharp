using System;

namespace Dados
{

    // ESSE PROJETO É BIBLIOTECA DE CLASSES (.NET CORE)
    public class Cadastro :ICadastro
    { 
        private string Nome { get; set; }
        private string Sobrenome { get; set; }
        private int Idade { get; set; }


        public void Cadastrar(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;

        }

        public string Imprimir()
        {
            return $"{Nome} {Sobrenome} {Idade}";
        }

        
    }
}
