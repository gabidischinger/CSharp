using Lista8_interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lista8_negocio
{
    public class BibliotecaNegocio
    {

        public static bool Emprestar(ref List<IEmprestimoDado> emprestimos, IEmprestimoDado livroEmprestado)
        {
            IEmprestimoDado procurarLivro = emprestimos.FirstOrDefault(e => e.GetLivroDado().GetTombo().Equals(livroEmprestado.GetLivroDado().GetTombo()));

            if (procurarLivro == null)
            {
                emprestimos.Add(livroEmprestado);
                return true;
            }
            else
                return false;

        }

        public static bool Devolver(ref List<IEmprestimoDado> emprestimos, int id)
        {
            IEmprestimoDado procurarEmprestimo = emprestimos.FirstOrDefault(e => e.GetId().Equals(id));

            if (procurarEmprestimo == null)
            {                
                return false;
            }
            else
            {
                emprestimos.Remove(procurarEmprestimo);
                return true;
            }
                
        }

        public static ILivroDado ProcurarLivro(ILivroDado livro,List<ILivroDado> livros, int tombo)
        {
             return livro.PesquisarLivro(livros, tombo);
        }

        public static IPessoaDado ProcurarPessoa(IPessoaDado pessoa, List<IPessoaDado> pessoas, string cpf)
        {
            return pessoa.PesquisarPessoa(pessoas, cpf);
        }

        public static IEmprestimoDado ProcurarEmprestimo(List<IEmprestimoDado> emprestimos, int id)
        {
            return emprestimos.FirstOrDefault(e => e.GetId().Equals(id));
            
        }

        public static bool DeletarLivro(ILivroDado livro, List<ILivroDado> livros, List<IEmprestimoDado> emprestimos, int tombo)
        {
            bool livroDeletado = livro.DeletarLivro(ref livros, emprestimos, tombo);
            return livroDeletado;
        }

        public static bool DeletarPessoa(IPessoaDado pessoa, List<IPessoaDado> pessoas, string cpf)
        {
            bool pessoaDeletada = pessoa.DeletarPessoas(ref pessoas, cpf);
            return pessoaDeletada;
        }

    }
}
