using System;
using System.Collections.Generic;
using System.Text;

namespace Lista8_interfaces
{
    public interface ILivroDado
    {
        int Tombo { get; set; }
        string Titulo { get; set; }
        string Autor { get; set; }
    }
}
