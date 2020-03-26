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
                        PesquisarLivro();
                        break;
                    case 3:
                        DeletarLivro();
                        break;
                    case 4:
                        CadastrarPessoa();
                        break;
                    case 5:
                        PesquisarPessoa();
                        break;
                    case 6:
                        DeletarPessoa();
                        break;
                    case 7:
                        AlugarLivro();
                        break;
                    case 8:
                        DevolverLivro();
                        break;
                    case 9:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção invalida, tente novamente.");
                        Console.WriteLine();
                        break;

                }

            } while (opcao != 9);
        }

        static void Menu()
        {
            StringBuilder menu = new StringBuilder();
            menu.Append("Digite a opção desejada:");
            menu.Append("\n1 - Cadastrar livro");
            menu.Append("\n2 - Pesquisar livro");
            menu.Append("\n3 - Deletar livro");
            menu.Append("\n4 - Cadastrar pessoa");
            menu.Append("\n5 - Pesquisar pessoa");
            menu.Append("\n6 - Deletar pessoa");
            menu.Append("\n7 - Emprestar livro");
            menu.Append("\n8 - Devolver livro");
            menu.Append("\n9 - Sair");

            Console.WriteLine(menu);

        }


        static void CadastrarLivro()
        {
            Console.WriteLine("Digite o título do livro:");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o autor do livro:");
            string autor = Console.ReadLine();

            int tombo = new Random().Next();

            ILivroDado livro = new LivroDado();
            livro.CadastrarLivro(tombo, titulo, autor);
            livros.Add(livro);

            Console.WriteLine("Livro cadastrado com sucesso.");
            Console.WriteLine($"Titulo: {livro.GetTitulo()}");
            Console.WriteLine($"Autor: {livro.GetAutor()}");
            Console.WriteLine($"Tombo: {livro.GetTombo()}");
            Console.WriteLine();
            Console.WriteLine();

        }

        static void PesquisarLivro()
        {
            Console.WriteLine("Digite o tombo do livro que deseja buscar:");
            int tombo = int.Parse(Console.ReadLine());

            ILivroDado livroPesquisado = new LivroDado();
            livroPesquisado = BibliotecaNegocio.ProcurarLivro(livroPesquisado, livros, tombo);

            if(livroPesquisado == null)
            {
                Console.WriteLine("Livro não encontrado");
            } else
            {
                Console.WriteLine("Livro encontrado:");
                Console.WriteLine($"Titulo do livro: {livroPesquisado.GetTitulo()}");
                Console.WriteLine($"Autor do livro: {livroPesquisado.GetAutor()}");
                Console.WriteLine();
                Console.WriteLine();
            }

        }

        static void DeletarLivro()
        {
            bool livroDeletado = false;

            do
            {
                Console.WriteLine("Digite o tombo do livro que deseja deletar:");
                int tombo = int.Parse(Console.ReadLine());

                ILivroDado livro = new LivroDado();
                livroDeletado = BibliotecaNegocio.DeletarLivro(livro, livros, emprestimos, tombo);

            } while (livroDeletado == false);

        }

        static void CadastrarPessoa()
        {
            Console.WriteLine("Digite o CPF:");
            string cpf = Console.ReadLine();
                            
            Console.WriteLine("Digite o nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o email:");
            string email = Console.ReadLine();

            IPessoaDado pessoa = new PessoaDado();
            pessoa.CadastrarPessoa(cpf, nome, email);
            pessoas.Add(pessoa);

            Console.WriteLine("Pessoa cadastrada com sucesso");
            Console.WriteLine();
            Console.WriteLine();

        }

        static void PesquisarPessoa()
        {
            Console.WriteLine("Digite o CPF da pessoa que deseja buscar:");
            string cpf = Console.ReadLine();

            IPessoaDado pessoaPesquisada = new PessoaDado();
            pessoaPesquisada = BibliotecaNegocio.ProcurarPessoa(pessoaPesquisada, pessoas, cpf);

            if (pessoaPesquisada == null)
            {
                Console.WriteLine("Pessoa não encontrado");
            }
            else
            {
                Console.WriteLine("Pessoa encontrada:");
                Console.WriteLine($"Nome da pessoa: {pessoaPesquisada.GetNome()}");
                Console.WriteLine($"Email da pessoa: {pessoaPesquisada.GetEmail()}");
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void DeletarPessoa()
        {
            bool pessoaDeletada = false;

            do
            {
                Console.WriteLine("Digite o CPF da pessoa que deseja deletar:");
                string cpf = Console.ReadLine();

                IPessoaDado pessoa = new PessoaDado();
                pessoaDeletada = BibliotecaNegocio.DeletarPessoa(pessoa, pessoas, cpf);

            } while (pessoaDeletada == false);
        }

        static void AlugarLivro()
        {
            IPessoaDado pessoa = new PessoaDado();
            ILivroDado livro = new LivroDado();
            string cpf;
            int tombo;
            
            if(pessoas.Count >= 1 && livros.Count >= 1)
            {
                do
                {
                    Console.WriteLine("Digite o CPF da pessoa que deseja alugar um livro:");
                    cpf = Console.ReadLine();
                    pessoa = BibliotecaNegocio.ProcurarPessoa(pessoa, pessoas, cpf);

                    if (pessoa == null)
                    {
                        Console.WriteLine("CPF inválido, tente novamente.");
                    }

                } while (pessoa == null);

                do
                {
                    Console.WriteLine("Digite o tombo do livro que deseja ser alugado:");

                    tombo = int.Parse(Console.ReadLine());
                    livro = BibliotecaNegocio.ProcurarLivro(livro, livros, tombo);

                    if (livro == null)
                    {
                        Console.WriteLine("Livro inválido, tente novamente.");
                    }

                } while (livro == null);

                int id = new Random().Next();
                IEmprestimoDado livroEmprestado = new EmprestimoDado(id, DateTime.Today, livro, pessoa);
                bool emprestar = BibliotecaNegocio.Emprestar(ref emprestimos, livroEmprestado);

                if (emprestar)
                {
                    Console.WriteLine("Livro emprestado com sucesso");
                    Console.WriteLine($"ID do emprestimo: {livroEmprestado.GetId()}");
                    Console.WriteLine($"Data do emprestimo: {livroEmprestado.GetDataEmprestimo()}");
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
