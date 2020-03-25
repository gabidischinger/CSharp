using System;
using System.Collections.Generic;
using System.Text;

namespace Lista8_interfaces
{
    public interface IEmprestimoDado
    {
        int Id { get; set; }
        DateTime DataEmprestimo { get; set; }
        ILivroDado LivroDado { get; set; }
        IPessoaDado PessoaDado { get; set; }

    }
}
