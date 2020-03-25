using Lista8_interfaces;
using System;

namespace Lista8_dado
{
    public class LivroDado : ILivroDado
    {

        public int Tombo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }


        public LivroDado(int tombo, string titulo, string autor)
        {
            Tombo = tombo;
            Titulo = titulo;
            Autor = autor;
        }

        
    }
}
