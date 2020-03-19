using System;
using Dados;
using Negocios;

namespace ConsoleMultiprojetos
{

    //para ler outro projeto tem que ir em dependência, clicar com botão direito
    //selecionar projeto que projeto deseja ser lido
    //por último incluir o namespace no using

    class Program
    {
        static void Main()
        {
            ICadastro cadastro = new Cadastro();
            cadastro.Cadastrar("Gabriela", "Miranda", 27);
            Console.WriteLine(cadastro.Imprimir());

            AnalisarCadastro analisarCadastro = new AnalisarCadastro();
            bool ok = analisarCadastro.Analisar(cadastro.Imprimir());
            if (ok)
                Console.WriteLine("Cadastro ok");
            else
                Console.WriteLine("Não ok");
        }
    }
}
