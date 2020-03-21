using System;
using System.Text;
using Comum;

namespace Negocios
{
    public class AnalisarCadastro
    {
        public string Analisar(ICadastro icadastro)
        {
            StringBuilder validacao = new StringBuilder();

            if (string.IsNullOrEmpty(icadastro.GetNome()))
                validacao.Append("\nNome invalido");

            if (string.IsNullOrEmpty(icadastro.GetSobrenome()))
                validacao.Append("\nSobrenome invalido");

            if (icadastro.GetIdade() < 1 || icadastro.GetIdade() > 150)
                validacao.Append("\nIdade invalida");

            return validacao.ToString();
        }

        
    }
}
