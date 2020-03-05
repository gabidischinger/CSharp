using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Exercícios.ListaExers5
{
    class Exer3_Stack
    {
        public static void CriarStack()
        {
            int opcao = 0;
            Stack<int> numeros = new Stack<int>();

            do
            {
                Console.WriteLine();
                Console.WriteLine("Escolha a opção desejada:");
                Console.WriteLine("1 - Inserir número");
                Console.WriteLine("2 - Remover número");
                Console.WriteLine("3 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        InserirNumero(numeros);
                        break;
                    case 2:
                        RemoverNumero(numeros);
                        break;
                }


            } while (opcao != 3);
        }

        private static void RemoverNumero(Stack<int> numeros)
        {
            numeros.Pop();

            Console.WriteLine();
            Console.WriteLine("Lista de números atualizada:");

            foreach (var num in numeros)
            {
                Console.WriteLine(num);
            }

        }

        private static void InserirNumero(Stack<int> numeros)
        {
            Console.WriteLine("Digite um número:");
            numeros.Push(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Lista de números atualizada:");
            
            foreach(var num in numeros)
            {
                Console.WriteLine(num);
            }
        }
    }
}
