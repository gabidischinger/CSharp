using System;
using System.Text;

namespace Lista6
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder opcoes = new StringBuilder();
            opcoes.Append("Selecione com qual conta gostaria de fazer o login:");
            opcoes.Append("\n1 - Gmail");
            opcoes.Append("\n2 - Facebook");
            opcoes.Append("\n3 - Intagram");
            opcoes.Append("\n4 - Sair");

            Console.WriteLine(opcoes);

            int opcao = Convert.ToInt32(Console.ReadLine());
            TipoLogin opc = (TipoLogin)opcao;

            string usuario = "";
            string senha = "";

            if (opcao > 0  && opcao < 4)
            {
                Console.WriteLine("Digite o usuario:");
                usuario = Console.ReadLine();

                Console.WriteLine("Digite a senha:");
                senha = Console.ReadLine();
            }
            

            switch(opc)
            {
                case TipoLogin.Gmail:
                    LoginGmail loginGmail = new LoginGmail();
                    if (loginGmail.Login(usuario, senha, TipoLogin.Gmail))
                        Console.WriteLine("Login realizado via Gmail");
                    else
                        Console.WriteLine("Erro ao fazer login");

                    if (loginGmail.Logout())
                        Console.WriteLine("Logout");
                    break;


                case TipoLogin.Facebook:
                    LoginFacebook loginFacebook = new LoginFacebook();
                    if (loginFacebook.Login(usuario, senha, TipoLogin.Facebook))
                        Console.WriteLine("Login realizado via Facebook");
                    else
                        Console.WriteLine("Erro ao fazer login");

                    if (loginFacebook.Logout())
                        Console.WriteLine("Logout");
                    break;


                case TipoLogin.Instagram:
                    LoginInstagram loginInstagram = new LoginInstagram();
                    loginInstagram.Login(usuario, senha, TipoLogin.Instagram);


                    if (loginInstagram.Logout())
                        Console.WriteLine("Logout");
                    break;


                default:
                    break;
            }


        }
    }
}
