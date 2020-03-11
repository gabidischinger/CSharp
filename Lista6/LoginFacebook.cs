using System;
using System.Collections.Generic;
using System.Text;

namespace Lista6
{
    public class LoginFacebook : SuperLogin
    {
        public override bool Login(string usuario, dynamic senha, TipoLogin tipo)
        {
            bool autenticacao = Autentica(usuario, senha, tipo);
            return autenticacao;
        }

        public override bool Logout()
        {
            return true;
        }
    }
}
