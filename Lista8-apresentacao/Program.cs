using Lista8_dado;
using Lista8_interfaces;
using Lista8_negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lista8_apresentacao
{
    class Program
    {
        public static List<ILivroDado> livros = new List<ILivroDado>();
        public static List<IPessoaDado> pessoas = new List<IPessoaDado>();
        public static List<IEmprestimoDado> emprestimos = new List<IEmprestimoDado>();

        static void Main()
        {
            int opcao = 0;

            do
            {
                Menu();
                
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                    Console.WriteLine("Tente novamente.");
                }


                switch (opcao)
                {
                    case 1:
                        CadastrarLivro();
                        break;
                    case 2:
                        CadastrarPessoa();
                        break;
                    case 3:
                        AlugarLivro();
                        break;
                    case 4:
                        DevolverLivro();
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção invalida, tente novamente.");
                        Console.WriteLine();
                        break;

                }

            } while (opcao != 5);
        }

        static void Menu()
        {
            StringBuilder menu = new StringBuilder();
            menu.Append("Digite a opção desejada:");
            menu.Append("\n1 - Cadastrar livro");
            menu.Append("\n2 - Cadastrar pessoa");
            menu.Append("\n3 - Emprestar livro");
            menu.Append("\n4 - Devolver livro");
            menu.Append("\n5 - Sair");

            Console.WriteLine(menu);

        }

        static void CadastrarLivro()
        {
            Console.WriteLine("Digite o título do livro:");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o autor do livro:");
            string autor = Console.ReadLine();

            int tombo = new Random().Next();

            ILivroDado livro = new LivroDado(tombo, titulo, autor);
            livros.Add(livro);

            Console.WriteLine("Livro cadastrado com sucesso.");
            Console.WriteLine($"Titulo: {livro.Titulo}");
            Console.WriteLine($"Autor: {livro.Autor}");
            Console.WriteLine($"Tombo: {livro.Tombo}");
            Console.WriteLine();
            Console.WriteLine();

        }

        static void CadastrarPessoa()
        {
            Console.WriteLine("Digite o CPF:");
            int cpf = 0;
            bool cpfValido = false;

            do
            {
                try
                {
                    cpf = int.Parse(Console.ReadLine());
                    cpfValido = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                    Console.WriteLine("Tente novamente.");
                    cpfValido = false;
                }
            } while (cpfValido == false);
                    
            
            Console.WriteLine("Digite o nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o email:");
            string email = Console.ReadLine();

            IPessoaDado pessoa = new PessoaDado(cpf, nome, email);
            pessoas.Add(pessoa);

            Console.WriteLine("Pessoa cadastrada com sucesso");
            Console.WriteLine();
            Console.WriteLine();

        }

        static void AlugarLivro()
        {
            IPessoaDado pessoa = null;
            ILivroDado livro = null;
            int cpf;
            int tombo;
            
            if(pessoas.Count >= 1 && livros.Count >= 1)
            {
                do
                {
                    Console.WriteLine("Digite o CPF da pessoa que deseja alugar um livro:");

                    try
                    {
                        cpf = int.Parse(Console.ReadLine());
                        pessoa = BibliotecaNegocio.ProcurarPessoa(pessoas, cpf);

                        if (pessoa == null)
                        {
                            Console.WriteLine("CPF inválido, tente novamente.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro: " + e.Message);
                        Console.WriteLine("Tente novamente.");
                        pessoa = null;
                    }

                } while (pessoa == null);

                do
                {
                    Console.WriteLine("Digite o tombo do livro que deseja ser alugado:");

                    tombo = int.Parse(Console.ReadLine());
                    livro = BibliotecaNegocio.ProcurarLivro(livros, tombo);

                    if (livro == null)
                    {
                        Console.WriteLine("Título inválido, tente novamente.");
                    }

                } while (pessoa == null);

                int id = new Random().Next();
                IEmprestimoDado livroEmprestado = new EmprestimoDado(id, DateTime.Today, livro, pessoa);
                bool emprestar = BibliotecaNegocio.Emprestar(ref emprestimos, livroEmprestado);

                if (emprestar)
                {
                    Console.WriteLine("Livro emprestado com sucesso");
                    Console.WriteLine($"ID do emprestimo: {livroEmprestado.Id}");
                    Console.WriteLine($"Data do emprestimo: {livroEmprestado.DataEmprestimo}");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Este livro já foi emprestado para outra pessoa");
                    Console.WriteLine();
                    Console.WriteLine();
                }

            } else
            {
                Console.WriteLine("Não há pessoas e/ou livros cadastrados. Cadastre e tente novamente.");
                Console.WriteLine();
                Console.WriteLine();
            }


        }

        static void DevolverLivro()
        {

            int id;
            bool devolver = false;

            do
            {
                Console.WriteLine("Digite o ID do emprestimo realizado:");

                try
                {
                    id = int.Parse(Console.ReadLine());

                    devolver = BibliotecaNegocio.Devolver(ref emprestimos, id);

                    if (devolver)
                    {
                        Console.WriteLine("Livro devolvido com sucesso");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("ID não encontrado, tente novamente");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                    Console.WriteLine("Tente novamente.");
                }

            } while (devolver == false);
            
        }
    }
}
