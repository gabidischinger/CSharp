using System;
using System.Collections.Generic;
using System.Text;

namespace Lista8_interfaces
{
    public interface ILivroDado
    {
        
        int GetTombo();
        string GetTitulo();
        string GetAutor();

        void CadastrarLivro(int tombo, string titulo, string autor);

        ILivroDado PesquisarLivro(List<ILivroDado> livros, int tombo);

        bool DeletarLivro(ref List<ILivroDado> livros, List<IEmprestimoDado> emprestimos, int tombo);
    }
}
