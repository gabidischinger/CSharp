using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Exercícios.ListaExers5
{
    class Exer4_Fila
    {
        public static void CriarFila()
        {
            int opcao = 0;
            Queue<int> numeros = new Queue<int>();

            do
            {
                Console.WriteLine();
                Console.WriteLine("Escolha a opção desejada:");
                Console.WriteLine("1 - Inserir número");
                Console.WriteLine("2 - Remover número");
                Console.WriteLine("3 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
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

        private static void RemoverNumero(Queue<int> numeros)
        {
            numeros.Dequeue();

            Console.WriteLine();
            Console.WriteLine("Lista de números atualizada:");

            foreach (var num in numeros)
            {
                Console.WriteLine(num);
            }
        }

        private static void InserirNumero(Queue<int> numeros)
        {
            Console.WriteLine();
            Console.WriteLine("Digite um número:");
            numeros.Enqueue(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Lista atualizada:");
            foreach (var num in numeros)
            {
                Console.WriteLine(num);
            }

        }
    }
}
