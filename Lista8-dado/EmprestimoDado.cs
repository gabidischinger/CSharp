using Lista8_interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lista8_dado
{
    public class EmprestimoDado : IEmprestimoDado
    {
        public int Id { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public ILivroDado LivroDado { get; set; }
        public IPessoaDado PessoaDado { get; set; }

        
        public EmprestimoDado(int id, DateTime dataemprestimo, ILivroDado livro, IPessoaDado pessoa)
        {
            Id = id;
            DataEmprestimo = dataemprestimo;
            LivroDado = livro;
            PessoaDado = pessoa;
        }
    }
}
