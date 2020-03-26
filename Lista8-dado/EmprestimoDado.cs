using Lista8_interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lista8_dado
{
    public class EmprestimoDado : IEmprestimoDado
    {
        int Id { get; set; }
        DateTime DataEmprestimo { get; set; }
        ILivroDado LivroDado { get; set; }
        IPessoaDado PessoaDado { get; set; }

        
        public EmprestimoDado(int id, DateTime dataemprestimo, ILivroDado livro, IPessoaDado pessoa)
        {
            Id = id;
            DataEmprestimo = dataemprestimo;
            LivroDado = livro;
            PessoaDado = pessoa;
        }

        public int GetId()
        {
            return Id;
        }

        public DateTime GetDataEmprestimo()
        {
            return DataEmprestimo;
        }

        public ILivroDado GetLivroDado()
        {
            return LivroDado;
        }

        public IPessoaDado GetPessoaDado()
        {
            return PessoaDado;
        }
    }
}
