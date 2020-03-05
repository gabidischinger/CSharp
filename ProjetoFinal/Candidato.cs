using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Mod1
{
    public class Candidato
    {
        public string Nome { get; set; }
        public int Numero { get; }
        public TipoCandidato Tipo { get; set; }

        public Candidato(string nome, int numero, TipoCandidato tipo)
        {
            Nome = nome;
            Numero = numero;
            Tipo = tipo;
        }


    }
}
