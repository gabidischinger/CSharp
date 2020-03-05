using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Exercícios.Lista4
{
    public class Conta
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public double Saldo { get; set; }
        public DateTime Modificado { get; set; }
        public DateTime Criado { get; set; }

        public Conta(string id, string nome, string cpf, string email, double saldo, DateTime modificado, DateTime criado)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Saldo = saldo;
            Modificado = modificado;
            Criado = criado;
        }

    }
}
