using Lista8_interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lista8_dado
{
    public class PessoaDado : IPessoaDado
    {
        public int CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public PessoaDado(int cpf, string nome, string email)
        {
            CPF = cpf;
            Nome = nome;
            Email = email;
        }
    }
}
