using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Exercícios
{
    class ListaExers2
    {
        static void Main()
        {
            Exer1();
            Exer2();
            Exer3();
            Exer4();
            Exer5();
            Exer6();
            Exer7();
        }

        static void Exer1()
        {
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = Convert.ToInt32(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            if (media >= 6)
                Console.WriteLine("Passou");
            else
                Console.WriteLine("Não passou");
        }

        static void Exer2()
        {
            Console.WriteLine("Digite 'i' para inserir, 'e' para editar  ou 'r' para remover");
            string comando = Console.ReadLine();

            switch(comando)
            {
                case "i":
                    Console.WriteLine("Inserindo");
                    break;
                    
                case "e":
                    Console.WriteLine("Editando");
                    break;

                case "r":
                    Console.WriteLine("Removendo");
                    break;

                default:
                    Console.WriteLine("Comando inválido");
                    break;
            }
        }

        static void Exer3()
        {
            int[] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }

        static void Exer4()
        {
            double maior = 0;
            double menor = 0;
            double soma = 0;

            for (int i = 0; i < 3; i ++)
            {
                Console.WriteLine("Digite um número: ");
                double num = Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                {
                    maior = num;
                    menor = num;
                }
                else
                {
                    if (num > maior)
                        maior = num;
                    if (num < menor)
                        menor = num;
                }

                soma = soma + num;
            }

            double media = soma / 3;

            Console.WriteLine($"Maior: {maior}");
            Console.WriteLine($"Menor: {menor}");
            Console.WriteLine($"Média: {media}");


        }

        static void Exer5()
        {
            int[] array = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool contem = true;
            int contador = 0;

            //while (contem && contador < array.Length)
            //{
            //    if (num == array[contador])
            //    {
            //        contem = false;
            //    } else 
            //    {
            //        contador++;
            //    }
            //}

            //if (contem == false)
            //    Console.WriteLine("Sim");
            //else
            //    Console.WriteLine("Não");

            while (contem && contador < array.Length)
            {
                if (num == array[contador])
                {
                    contem = false;
                    Console.WriteLine("Sim");
                }
                else if (contador == (array.Length - 1) && num != array[contador])
                {
                    contem = false;
                    Console.WriteLine("Não");
                }
                else
                {
                    contador++;
                }
                
            }

        }

        static void Exer6()
        {
            Console.WriteLine("Digite a quantidade que deseja comprar: ");
            int quant = Convert.ToInt32(Console.ReadLine());
            double compra;

            if (quant < 100)
            {
                compra = quant * 0.5;
                Console.WriteLine($"Valor da compra: {compra.ToString("C")}");
            }
            else
            {
                compra = quant * 0.2;
                Console.WriteLine($"Valor da compra: {compra.ToString("C")}");
            }
        }

        static void Exer7()
        {
            Console.WriteLine("Digite as datas que deseja comparar.");
            
            Console.WriteLine("Digite o dia da primeira data:");
            int dia1 = Convert.ToInt32(Console.ReadLine());
            while (dia1 > 31)
            {
                Console.WriteLine("Digite um dia válido.");
                dia1 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Digite o mês da primeira data:");
            int mes1 = Convert.ToInt32(Console.ReadLine());
            while (mes1 > 12)
            {
                Console.WriteLine("Digite um mês válido.");
                mes1 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Digite o ano da primeira data:");
            int ano1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o dia da segunda data:");
            int dia2 = Convert.ToInt32(Console.ReadLine());
            while (dia2 > 31)
            {
                Console.WriteLine("Digite um dia válido.");
                dia2 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Digite o mês da segunda data:");
            int mes2 = Convert.ToInt32(Console.ReadLine());
            while (mes2 > 12)
            {
                Console.WriteLine("Digite um mês válido.");
                mes2 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Digite o ano da segunda data:");
            int ano2 = Convert.ToInt32(Console.ReadLine());


            if (ano2 > ano1)
            {
                Console.WriteLine("A segunda data é depois da primeira data.");
            } 
            else if (ano2 < ano1)
            {
                Console.WriteLine("A segunda data é antes da primeira data.");
            } 
            else
            {
                if (mes2 > mes1)
                {
                    Console.WriteLine("A segunda data é depois da primeira data.");
                }
                else if (mes2 < mes1)
                {
                    Console.WriteLine("A segunda data é antes da primeira data.");
                }
                else
                {
                    if (dia2 > dia1)
                    {
                        Console.WriteLine("A segunda data é depois da primeira data.");
                    }
                    else if (dia2 < dia1)
                    {
                        Console.WriteLine("A segunda data é antes da primeira data.");
                    }
                    else
                    {
                        Console.WriteLine("As datas são iguais.");
                    }
                }
            }
        }


    }
}
