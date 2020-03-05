using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Exercícios.Lista4
{
    public class ContaMax : Conta
    {
        public const double Taxa = 1.3;

        public ContaMax(string id, string nome, string cpf, string email, double saldo, DateTime modificado, DateTime criado) : base(id, nome, cpf, email, saldo, modificado, criado)
        {
        }

        public void Imprimir ()
        {
            Console.WriteLine("Tipo de Conta: MAX");
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
