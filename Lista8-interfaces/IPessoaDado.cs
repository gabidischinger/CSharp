using System;
using System.Collections.Generic;

namespace Lista8_interfaces
{
    public interface IPessoaDado
    {
        string GetCPF();
        string GetNome();
        string GetEmail();

        void CadastrarPessoa(string cpf, string nome, string email);

        IPessoaDado PesquisarPessoa(List<IPessoaDado> pessoa, string cpf);

        bool DeletarPessoas(ref List<IPessoaDado> pessoas, string cpf);

    }
}
