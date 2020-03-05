using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Exercícios.Lista4
{
    public static class Investimento
    {
        public static double Investir(Conta conta)
        {

            if (conta.GetType().Name == typeof(ContaMax).Name)
            {
                ContaMax contaMax = (ContaMax)conta;
                return contaMax.Saldo * ContaMax.Taxa;
            }
            else
            {
                ContaUniversitaria contaUniversitaria = (ContaUniversitaria)conta;
                return contaUniversitaria.Saldo * ContaUniversitaria.Taxa;
            }
        }
    }
}
