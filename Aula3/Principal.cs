using System;
using System.Collections.Generic;
using System.Text;

namespace Aulas
{
    class Principal
    {
        static void Main()
        {
            //VETORES ------------------------------
            string[] cidades = { "São Paulo", "Rio de Janeiro" };
            Console.WriteLine("Cidade: " + cidades[0]);

            string[] pessoas = new string[5];
            pessoas[0] = "Um";
            pessoas[1] = "Dois";
            pessoas[2] = "Tres";
            pessoas[3] = "Quatro";
            //pessoas[4] = "Cinco";

            Console.WriteLine("Pessoa: " + pessoas[4]);

            //pessoas[5] seria um valor nulo, que quebraria o código, enqaundo o pessoas[4] comentado é um valor vazio e não quebra o código


            //ATUALIZAR - sobrecrever
            Console.WriteLine("Pessoa indice 2: " + pessoas[2]);
            pessoas[2] = "Terceiro";
            Console.WriteLine("Pessoa indice 2: " + pessoas[2]);

            //REMOVER -  não é possivel. Uma forma é passar um valor em branco.
            pessoas[2] = "";
            Console.WriteLine("Pessoa indice 2: " + pessoas[2]);

            //CONDICIONAIS-------------------------------- -
            bool a = true;

            if (a == true)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            //tipo boolean não precisa ser comparado
            if (a)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            int num = 10;

            if (num > 5)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            //é sensível a caixa baixa ou alta
            string nome = "Gabi";
            if (nome == "gabi")
                Console.WriteLine("true");
            else
                Console.WriteLine("false");


            //chaves só são necessárias quando tem mais de uma linha
            if (nome.ToUpper().Equals("GABI"))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            string semaforo = "amarelo";

            if (semaforo.ToUpper().Equals("VERMELHO"))
            {
                Console.WriteLine("Vermelho");
            }
            else if (semaforo.ToUpper().Equals("AMARELO"))
            {
                Console.WriteLine("Amarelo");
            }
            else
            {
                Console.WriteLine("Verde");
            }

            switch (semaforo.ToUpper())
            {
                case "VERMELHO":
                    Console.WriteLine("Vermelho");
                    break;
                case "AMARELO":
                    Console.WriteLine("Amarelo");
                    break;
                default:
                    Console.WriteLine("Verde");
                    break;
            }


            //LOOPS ----------------------------------------
            bool status = true;
            int cont = 0;
            while (status)
            {
                Console.WriteLine("True");

                if (cont == 5)
                    status = false;
                else
                    cont++;

            }

            status = true;
            cont = 0;
            //enquanto for true, o while vai rodar e entra pode entrar em um loop infinito.
            //do sempre vai executar pelo menos uma vez
            do
            {
                Console.WriteLine("True");

                if (cont == 5)
                    status = false;
                else
                    cont++;
            } while (status);

            string[] cidades2 = { "São Paulo", "Campinas", "Rio de Janeiro", "Natal" };

            for (int i = 0; i < cidades.Length; i++)
            {
                Console.WriteLine("Cidade indice " + i + ": " + cidades[i]);
            }

            // length sempre vai ser o tamanho exato do array

            foreach (string item in cidades)
            {
                Console.WriteLine("Cidade: " + item);
            }


        }
    }
}
