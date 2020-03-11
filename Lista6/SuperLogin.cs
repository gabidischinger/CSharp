using System;
using System.Collections.Generic;
using System.Text;

namespace Lista6
{
    public abstract class SuperLogin
    {
        public abstract bool Login(string usuario, dynamic senha, TipoLogin tipo);

        public abstract bool Logout();

        protected virtual bool Autentica(string usuario, dynamic senha, TipoLogin tipo)
        {
            switch(tipo)
            {
                case TipoLogin.Gmail:
                    if (usuario == "gmail" && senha == "123")
                        return true;
                    else
                        return false;

                case TipoLogin.Facebook:
                    if (usuario == "facebook" && senha == "321")
                        return true;
                    else
                        return false;

                case TipoLogin.Instagram:
                    if (usuario == "instagram" && senha == "132")
                        return true;
                    else
                        return false;

                default:
                    return false;

            }
        }
    }
}
