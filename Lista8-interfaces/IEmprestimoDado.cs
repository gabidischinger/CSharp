using System;
using System.Collections.Generic;
using System.Text;

namespace Lista8_interfaces
{
    public interface IEmprestimoDado
    {
        
        int GetId();
        DateTime GetDataEmprestimo();
        ILivroDado GetLivroDado();
        IPessoaDado GetPessoaDado();


    }
}
