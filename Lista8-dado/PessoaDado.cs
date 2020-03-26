using Lista8_interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista8_dado
{
    public class PessoaDado : IPessoaDado
    {
        string CPF { get; set; }
        string Nome { get; set; }
        string Email { get; set; }

        
        public void CadastrarPessoa(string cpf, string nome, string email)
        {
            CPF = cpf;
            Nome = nome;
            Email = email;
        }

        public string GetCPF()
        {
            return CPF;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetEmail()
        {
            return Email;
        }

        public IPessoaDado PesquisarPessoa(List<IPessoaDado> pessoas, string cpf)
        {
            return pessoas.FirstOrDefault(p => p.GetCPF().Equals(cpf));
        }

        public bool DeletarPessoas(ref List<IPessoaDado> pessoas, string cpf)
        {
            IPessoaDado procurarPessoa = pessoas.FirstOrDefault(p => p.GetCPF().Equals(cpf));

            if (procurarPessoa == null)
            {
                return false;
            }
            else
            {
                pessoas.Remove(procurarPessoa);
                return true;
            }
        }

    }
}
