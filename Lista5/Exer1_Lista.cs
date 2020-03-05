using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Exercícios.ListaExers5
{
    class Exer1_Lista
    {
        public static void CriarLista()
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um número: ");
                numeros.Add(Convert.ToInt32(Console.ReadLine()));
            }

            // Imprimir original
            ImprimirOriginal(numeros);

            // Imprimir ordem crescente
            ImprimirCrecente(numeros);


            // Imprimir ordem decrescente
            ImprimirDecrescente(numeros);

            // Tamanho da lista
            ImprimirTamanho(numeros);

        }

        private static void ImprimirTamanho(List<int> numeros)
        {
            Console.WriteLine();
            Console.WriteLine("Tamanho da lista: " + numeros.Count);
        }

        private static void ImprimirDecrescente(List<int> numeros)
        {
            numeros.Reverse();
            Console.WriteLine();
            Console.WriteLine("Ordem decrescente:");
            foreach (var num in numeros)
            {
                Console.WriteLine(num);
            }

        }

        private static void ImprimirCrecente(List<int> numeros)
        {
            numeros.Sort();
            Console.WriteLine();
            Console.WriteLine("Ordem crescente:");
            foreach (var num in numeros)
            {
                Console.WriteLine(num);
            }
        }

        private static void ImprimirOriginal(List<int> numeros)
        {
            Console.WriteLine();
            Console.WriteLine("Ordem original:");
            foreach (var num in numeros)
            {
                Console.WriteLine(num);
            }
        }
    }
}
