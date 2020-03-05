using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Mod1
{
    public static class Eleicao
    {

        public static void Votar(Candidato candidato)
        {

            Principal.listaVotos.Add(candidato);

            Console.WriteLine("Voto computado com sucesso!");
            Console.WriteLine();

        }

        public static void Contagem()
        {

            double votosNulos = 0;
            double votosBrancos = 0;
            double votosCandidato1 = 0;
            double votosCandidato2 = 0;

            foreach (var candidato in Principal.listaVotos)
            {
                if (candidato.Tipo == TipoCandidato.Nulo)
                {
                    votosNulos += 1;
                } 
                else if (candidato.Tipo == TipoCandidato.Branco)
                {
                    votosBrancos += 1;
                }
                else if (candidato.Numero == Principal.numeroCandidato1)
                {
                    votosCandidato1 += 1;
                }
                else if (candidato.Numero == Principal.numeroCandidato2)
                {
                    votosCandidato2 += 1;
                }
            }

            double percentNulos = votosNulos / Principal.listaVotos.Count * 100;
            double percentBrancos = votosBrancos / Principal.listaVotos.Count * 100;
            double percentCandidato1 = votosCandidato1 / Principal.listaVotos.Count * 100;
            double percentCandidato2 = votosCandidato2 / Principal.listaVotos.Count * 100;

            string vencedor;

            if (votosCandidato1 > votosCandidato2)
            {
                vencedor = Principal.listaCandidatos[0].Nome;
            }
            else if (votosCandidato2 > votosCandidato1)
            {
                vencedor = Principal.listaCandidatos[1].Nome;
            }
            else
            {
                vencedor = "Empate";
            }



            Console.WriteLine();
            Console.WriteLine("###     CONFERIR CONTAGEM     ###");
            Console.WriteLine($"Quantidade total de votos: {Principal.listaVotos.Count}");
            Console.WriteLine($"Porcentagem de votos nulos: {percentNulos.ToString("F2")}%");
            Console.WriteLine($"Porcentagem de votos brancos: {percentBrancos.ToString("F2")}%");
            Console.WriteLine($"Votos por candidato: {Principal.listaCandidatos[0].Nome} - {votosCandidato1} ({percentCandidato1.ToString("F2")}%) / {Principal.listaCandidatos[1].Nome} - {votosCandidato2} ({percentCandidato2.ToString("F2")}%)");
            Console.WriteLine($"Candidato vencedor: {vencedor}");
            Console.WriteLine();

        }
    }
}
