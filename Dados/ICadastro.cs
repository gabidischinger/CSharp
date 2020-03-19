using System;
using System.Collections.Generic;
using System.Text;

namespace Dados
{
    public interface ICadastro
    {
        void Cadastrar(string nome, string sobrenome, int idade);
        string Imprimir();
    }
}
