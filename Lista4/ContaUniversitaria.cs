using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Exercícios.Lista4
{
    class ContaUniversitaria : Conta
    {
        public const double Taxa = 1.1;
        public ContaUniversitaria(string id, string nome, string cpf, string email, double saldo, DateTime modificado, DateTime criado) : base(id, nome, cpf, email, saldo, modificado, criado)
        {
        }

        public void Imprimir()
        {
            Console.WriteLine("Tipo de conta: UNIVERSITÁRIA");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"E-mail: {Email}");
            Console.WriteLine($"Saldo: {Saldo.ToString("C")}");
            Console.WriteLine($"Modificado: {Modificado}");
            Console.WriteLine($"Criado: {Criado}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
