using System;
using System.Collections.Generic;
using System.Text;

namespace Lista6
{
    public class LoginInstagram : SuperLogin
    {
        public override bool Login(string usuario, dynamic senha, TipoLogin tipo)
        {
            Autentica(usuario, senha);
            return true;
        }

        public override bool Logout()
        {
            return true;
        }

        protected void Autentica(string usuario, dynamic senha)
        {
            if (usuario == "instagram" && senha == "132")
                Console.WriteLine("Sucesso! Login realizado via Instagram");
            else
                Console.WriteLine("Não foi possível realizar o login via Instagram");
        }
    }
}
