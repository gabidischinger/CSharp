using Lista8_interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lista8_dado
{
    public class LivroDado : ILivroDado
    {

        int Tombo { get; set; }
        string Titulo { get; set; }
        string Autor { get; set; }


        public void CadastrarLivro(int tombo, string titulo, string autor)
        {
            Tombo = tombo;
            Titulo = titulo;
            Autor = autor;
        }

        public int GetTombo()
        {
            return Tombo;
        }

        public string GetTitulo()
        {
            return Titulo;
        }

        public string GetAutor()
        {
            return Autor;
        }

        public ILivroDado PesquisarLivro(List<ILivroDado> livros, int tombo)
        {
            return livros.FirstOrDefault(l => l.GetTombo().Equals(tombo));
        }

        public bool DeletarLivro(ref List<ILivroDado> livros, List<IEmprestimoDado> emprestimos, int tombo)
        {
            ILivroDado procurarLivro = livros.FirstOrDefault(l => l.GetTombo().Equals(tombo));

            IEmprestimoDado procurarEmprestimo = emprestimos.FirstOrDefault(e => e.GetLivroDado().GetTombo().Equals(tombo));

            if (procurarEmprestimo == null)
            {
                if (procurarLivro == null)
                {
                    Console.WriteLine("Livro não encontrado, tente novamente");
                    return false;
                }
                else
                {
                    Console.WriteLine("Livro deletado com sucesso");
                    livros.Remove(procurarLivro);
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Não é possível deletar este livro, está emprestado no momento");
                return true;
            }
                                   
        }

    }
}
