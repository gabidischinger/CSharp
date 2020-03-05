using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Aulas.Aula8
{
    class Principal
    {
        //lista - entra e sai o escolhido
        //queu - entra no final, sai do começo
        //stack - o ultimo a entrar é o primeiro a sair

        static void Main()
        {
            Console.WriteLine("Collection");

            #region Lista
            //Lista só aceita um tipo de variável
            //Count = length
            List<string> lista = new List<string>();

            lista.Add("June");
            lista.Add("Titi");
            lista.Add("Bili");
            lista.Add("Luli");

            Console.WriteLine(lista[3]);
            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Dicionário

            Console.WriteLine();
            Console.WriteLine();

            //sempre vai receber dois tipos
            Dictionary<int, string> dicionario = new Dictionary<int, string>();
            dicionario.Add(1, "Item A");
            dicionario.Add(2, "Item B");
            dicionario.Add(3, "Item C");

            //dicionário vai ser acessado pelo primeiro valor do dicionário, nesse caso, os números, mas poderia ser string se fossse o caso.
            Console.WriteLine(dicionario[1]);
            Console.WriteLine(dicionario.GetValueOrDefault(1));

            Dictionary<string, int> dicionario2 = new Dictionary<string, int>();
            dicionario2.Add("Item A", 1);
            dicionario2.Add("Item B", 2);
            dicionario2.Add("Item C", 2);

            Console.WriteLine(dicionario2["Item A"]);

            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in dicionario)
            {
                Console.WriteLine("Key: " + item.Key + "\nValor: " + item.Value);
            }

            #endregion

            #region Queue

            Console.WriteLine();
            Console.WriteLine();

            Queue<string> q = new Queue<string>();

            //Adicionar
            q.Enqueue("Fila 1");
            q.Enqueue("Fila 2");
            q.Enqueue("Fila 3");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            //Tirar da fila - remove e retorna
            string itemnafila = q.Dequeue();

            Console.WriteLine(itemnafila);
            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Stack

            Console.WriteLine();
            Console.WriteLine();

            Stack<string> pilha = new Stack<string>();
            // Adiciona
            pilha.Push("Pilha 1");
            pilha.Push("Pilha 2");
            pilha.Push("Pilha 3");


            // último adicoinado é o primeiro
            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            // Remove - último item adicionado
            pilha.Pop();

            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }



            #endregion

            #region Tupla

            Console.WriteLine();
            Console.WriteLine();

            // Declaracao de uma tupla, já deve passar o construtor
            Tuple<int, string, string> tup = new Tuple<int, string, string>(1, "posiçao 1", "posiçao 2");

            Console.WriteLine(tup.Item1);

            #endregion

            PraticandoLista();
            PraticandoDicionario();

        }

        static void PraticandoLista()
        {
            List<int> ints = new List<int>();

            int opcao = 0;

            do
            {
                Console.WriteLine("Digite 1 para inserir um número, digite 2 para sair");
                // opcao = Convert.ToInt32(Console.ReadLine());
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Digite um número inteiro:");
                    ints.Add(Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine();
                    Console.WriteLine();


                    Console.WriteLine("Numeros na lista:");

                    foreach (var item in ints)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine();
                }
                else if (opcao != 1 && opcao != 2)
                {
                    Console.WriteLine("Digite uma opção válida!");
                }

            } while (opcao != 2);
        }

        static void PraticandoDicionario()
        {
            Dictionary<int, int> dicio = new Dictionary<int, int>();

            int opcao = 0;
            int key = 1;

            do
            {
                Console.WriteLine("Digite 1 para inserir um número, digite 2 para sair");
                // opcao = Convert.ToInt32(Console.ReadLine());
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Digite um número inteiro:");
                    dicio.Add(key, int.Parse(Console.ReadLine()));
                    key++;

                    Console.WriteLine();
                    Console.WriteLine();


                    Console.WriteLine("Numeros na lista:");

                    foreach (var item in dicio)
                    {
                        Console.WriteLine($"Key: {item.Key} -- Valor: {item.Value}");
                    }

                    Console.WriteLine();
                }
                else if (opcao != 1 && opcao != 2)
                {
                    Console.WriteLine("Digite uma opção válida!");
                }

            } while (opcao != 2);
        }

    }
}
