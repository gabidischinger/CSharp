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
            IEmprestimoDado procurarLivro = emprestimos.FirstOrDefault(e => e.LivroDado.Tombo.Equals(livroEmprestado.LivroDado.Tombo));

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
            IEmprestimoDado procurarEmprestimo = emprestimos.FirstOrDefault(e => e.Id.Equals(id));

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

        public static ILivroDado ProcurarLivro(List<ILivroDado> livros, int tombo)
        {
            return livros.FirstOrDefault(l => l.Tombo.Equals(tombo));

        }

        public static IPessoaDado ProcurarPessoa(List<IPessoaDado> pessoas, int cpf)
        {

            return pessoas.FirstOrDefault(p => p.CPF.Equals(cpf));
            
        }

        public static IEmprestimoDado ProcurarEmprestimo(List<IEmprestimoDado> emprestimos, int id)
        {
            return emprestimos.FirstOrDefault(e => e.Id.Equals(id));
            
        }

    }
}
