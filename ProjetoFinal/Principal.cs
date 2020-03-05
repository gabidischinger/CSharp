using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Mod1
{

    class Principal
    {

        public static List<Candidato> listaVotos = new List<Candidato>();
        public static List<Candidato> listaCandidatos = new List<Candidato>();
        public static int numeroCandidato1 = 0;
        public static int numeroCandidato2 = 0;

        static void Main()
        {
                       
            int opcao = 0;

            CriarCandidatos();

            do
            {
                StringBuilder opcoes = new StringBuilder();
                opcoes.Append("Digite a opção desejada:");
                opcoes.Append("\n1 - Votar");
                opcoes.Append("\n2 - Conferir contagem");
                opcoes.Append("\n3 - Sair");
                Console.WriteLine(opcoes);


                // Caso seja digitado um caracter ou string:
                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                }
                
                                
                switch (opcao)
                {
                    case 1:
                        Votar();
                        break;
                    case 2:
                        ConferirContagem();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opção invalida, tente novamente.");
                        Console.WriteLine();
                        break;
                    
                }

            } while (opcao != 3);

        }

        static void CriarCandidatos()
        {

            Console.WriteLine("###     CRIAR CANDIDATOS     ###");
            Console.WriteLine("Digite o nome do Candidato 1:");
            string nomeCandidato1 = Console.ReadLine();
                       
            bool caracter1 = false;
            do
            {
                Console.WriteLine("Digite o número do Candidato 1, , que seja diferente de 3 (votos nulos) e 4 (votos brancos):");

                try
                {
                    numeroCandidato1 = Convert.ToInt32(Console.ReadLine());

                    if (numeroCandidato1 == 3 || numeroCandidato1 == 4)
                    {
                        caracter1 = false;
                    }
                    else
                    {
                        caracter1 = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                    Console.WriteLine("Numero invalido, digite novamente.");
                }
            } while (caracter1 == false);



            Console.WriteLine("Digite o nome do Candidato 2:");
            string nomeCandidato2 = Console.ReadLine();

            bool caracter2 = false;
            do
            {
                Console.WriteLine("Digite o número do Candidato 2, que seja diferente de 3 (votos nulos) e 4 (votos brancos):");

                try
                {
                    numeroCandidato2 = Convert.ToInt32(Console.ReadLine());

                    if(numeroCandidato2 == 3 || numeroCandidato2 == 4)
                    {
                        caracter2 = false;
                    }
                    else
                    {
                        caracter2 = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                    Console.WriteLine("Numero invalido, digite novamente.");
                }
            } while (caracter2 == false);
            
         
            Candidato candidato1 = new Candidato(nomeCandidato1, numeroCandidato1, TipoCandidato.Valido);
            Candidato candidato2 = new Candidato(nomeCandidato2, numeroCandidato2, TipoCandidato.Valido);
            Candidato branco = new Candidato("Branco", 3, TipoCandidato.Branco);
            Candidato nulo = new Candidato("Nulo", 4, TipoCandidato.Nulo);

            listaCandidatos.Add(candidato1);
            listaCandidatos.Add(candidato2);
            listaCandidatos.Add(branco);
            listaCandidatos.Add(nulo);

        }

        static void Votar()
        {

            int voto = 1;
            bool votoValido = false;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Selecione a opção desejada:");
                foreach (var candidato in listaCandidatos)
                {
                    Console.WriteLine(candidato.Numero + " - " + candidato.Nome);
                }


                try
                {
                    voto = Convert.ToInt32(Console.ReadLine());

                    foreach(var candidato in listaCandidatos)
                    {
                        if(voto == candidato.Numero)
                        {
                            votoValido = true;
                            Eleicao.Votar(candidato);
                            break;
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                    Console.WriteLine("Entrada inválida, tente novamente!");
                }

            } while (votoValido == false);


           
        }

        static void ConferirContagem()
        {
            Eleicao.Contagem();
        }
    }
}
