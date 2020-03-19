using System;

namespace Negocios
{
    public class AnalisarCadastro
    {
        public bool Analisar(string cadastro)
        {
            bool ok = false;

            if (cadastro == "")
                ok = false;
            else
                ok = true;

            return ok;
        }
    }
}
