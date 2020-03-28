using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Exercícios.Lista4
{
    class Principal
    {
        static void Main()
        {
            Iniciar();
        }

        static void Iniciar()
        {
            int opcao = 10;

            do
            {
                Console.WriteLine("Selecione a opção desejada: ");
                Console.WriteLine("1 - Criar conta max");
                Console.WriteLine("2 - Criar conta universitaria");
                Console.WriteLine("3 - Imprimir conta");
                Console.WriteLine("4 - Investir");
                Console.WriteLine("0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        AdicionarMax();
                        break;
                    case 2:
                        AdicionarUniversitaria();
                        break;
                    case 3:
                        Imprimir();
                        break;
                    case 4:
                        Investir();
                        break;
                }
                

            } while (opcao != 0);
        }


        static Conta[] contas = new Conta[3];
        static int i = 0;

        static void AdicionarMax()
        {
           
            if (i < 3)
            {
                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o CPF:");
                string cpf = Console.ReadLine();
                Console.WriteLine("Digite seu email:");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o saldo inicial:");
                double saldo = Convert.ToDouble(Console.ReadLine());
                DateTime criado = DateTime.Now;
                DateTime modificado = DateTime.Now;
                string id = Guid.NewGuid().ToString();

                ContaMax contaMax = new ContaMax(id, nome, cpf, email, saldo, modificado, criado);
                contas[i] = contaMax;
                i++;
            }
            else
            {
                Console.WriteLine("Lista cheia!");
            }
        }
        
        static void AdicionarUniversitaria()
        {
            if (i < 3)
            {
                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o CPF:");
                string cpf = Console.ReadLine();
                Console.WriteLine("Digite seu email:");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o saldo inicial:");
                double saldo = Convert.ToDouble(Console.ReadLine());
                DateTime criado = DateTime.Now;
                DateTime modificado = DateTime.Now;
                string id = Guid.NewGuid().ToString();

                ContaUniversitaria contaUniversitaria = new ContaUniversitaria(id, nome, cpf, email, saldo, modificado, criado);
                contas[i] = contaUniversitaria;
                i++;
            }
            else
            {
                Console.WriteLine("Lista cheia!");
            }
        }

        static void Imprimir()
        {
            Console.WriteLine("IMPRIMINDO");
            foreach (var conta in contas)
            {
                if (conta != null)
                {
                    if (conta.GetType().Name == typeof(ContaMax).Name)
                    {
                        ContaMax contaMax = (ContaMax)conta;
                        contaMax.Imprimir();
                    }
                    else
                    {
                        ContaUniversitaria contaUniversitaria = (ContaUniversitaria)conta;
                        contaUniversitaria.Imprimir();
                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }            
        }
        
        static void Investir()
        {

            Console.WriteLine("Digite o GUID da conta que deseja investir:");
            string guid = Console.ReadLine();

            foreach (var item in contas)
            {
                

                if (item.Id == guid)
                {
                    double invest = Investimento.Investir(item);
                    item.Saldo = invest;
                    item.Modificado = DateTime.Now;
                    Console.WriteLine("Invesimento realizado com sucesso");
                    Console.WriteLine();
                    break;
                }
            }

        }

    }
}
