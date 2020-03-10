using System;

namespace CSharp_Modulo2
{
    class Program
    {
        static void Main()
        {
            LoginApp loginApp = new LoginApp();

            string usuario = "";
            string senha = "12345";

            loginApp.FazerLogin(usuario, senha);
            loginApp.FazerLogout();


            LoginSite loginSite = new LoginSite();

            string usuario2 = "gabi";
            string senha2 = "123456";

            loginSite.FazerLogin(usuario2, senha2);
            loginSite.FazerLogout();
            
        }


        //privado não é herdado
        //privado realmente só pode ser utilizado dentro da classe a que pertence
        //quando quer ser utilizado pelas classes filhas, mas não fora delas, usar protected.

        public abstract class Login
        {
            public abstract void FazerLogin(string usuario, dynamic senha);

            public abstract void FazerLogout();

            protected virtual bool ValidarSeguranca(string usuario, dynamic senha)
            {

                if (usuario == "" && senha == "12345")
                    return true;
                else
                    return false;

            }
        }

        public class LoginApp : Login
        {
            public override void FazerLogin(string usuario, dynamic senha)
            {               
                
                bool resultValidacao = ValidarSeguranca(usuario, senha);
                if (resultValidacao)
                    Console.WriteLine("Login realizado");
                else
                    Console.WriteLine("Login falhou");

            }

            public override void FazerLogout()
            {
                Console.WriteLine("Logout realizado");
            }
        }

        public class LoginSite : Login
        {
            public override void FazerLogin(string usuario, dynamic senha)
            {

                bool resultValidacao = ValidarSeguranca(usuario, senha);
                if (resultValidacao)
                    Console.WriteLine("Sucesso");
                else
                    Console.WriteLine("Falha");

            }

            public override void FazerLogout()
            {
                Console.WriteLine("Saiu");
            }

            protected override bool ValidarSeguranca(string usuario, dynamic senha)
            {
                if (usuario == "" && senha == "123")
                    return true;
                else
                    return false;
            }
        }

    }
}
