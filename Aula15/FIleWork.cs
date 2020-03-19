using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Aula15
{
    class FIleWork
    {
        
        static void Main()
        {
            //CriarPasta(@"D:\OneDrive\Estudos\Pi\C#\Aula15\", "Origem");
            //DeletarPasta(@"D:\OneDrive\Estudos\Pi\C#\Aula15\Origem");

            //CriarArquivo(@"D:\OneDrive\Estudos\Pi\C#\Aula15\", "teste.txt");
            //CriarArquivo(@"D:\OneDrive\Estudos\Pi\C#\Aula15\", "teste2.txt");

            //LerArquivo(@"D:\OneDrive\Estudos\Pi\C#\Aula15\", "teste2.txt");

            //DeletarArquivo(@"D:\OneDrive\Estudos\Pi\C#\Aula15\", "teste2.txt");

            //CopiarArquivo(@"D:\OneDrive\Estudos\Pi\C#\Aula15\", "teste.txt", @"D:\OneDrive\Estudos\Pi\C#\Aula15\", "teste_copia.txt");

            Console.WriteLine("Digite o nome da primeira pasta que deseja criar");
            string pasta1 = Console.ReadLine();

            string path1 = CriarPasta(@"D:\OneDrive\Estudos\Pi\C#\Aula15\", pasta1);
            

            Console.WriteLine("Digite o nome da segunda pasta que deseja criar");
            string pasta2 = Console.ReadLine();

            string path2 =  CriarPasta(@"D:\OneDrive\Estudos\Pi\C#\Aula15\", pasta2);


            Console.WriteLine("Digite o nome do arquivo de texto que deseja criar");
            string arquivo = (Console.ReadLine() + ".txt");
                        
            CriarArquivo(path1, arquivo);
            CopiarArquivo(path1, arquivo, path2, "copia_" + arquivo);

            LerArquivo(path2, "copia_" + arquivo);

        }
        

        #region Folder

        static string CriarPasta(string path, string folder)
        {
            string sourcePath = Path.Combine(path, folder);
             

            Directory.CreateDirectory(sourcePath);
            Console.WriteLine("Pasta criada com sucesso");

            return sourcePath;

        }

        static void DeletarPasta(string path)
        {
            Directory.Delete(path);
            Console.WriteLine("Pasta deletada com sucesso");
        }

        #endregion

        #region File

        static void CriarArquivo(string path, string file)
        {
            string caminho = path;
            string arquivo = file;
            string pathString = Path.Combine(caminho, arquivo);

            //File.CreateText(pathString);

            //para não correr risco de sobrescrever o arquivo - não vai alterar um arquivo que já existe
            if (!File.Exists(pathString))
            {
                using (StreamWriter sw = File.CreateText(pathString))
                {
                    //chave 0, pega o primeiro parâmetro pós virgula, funciona como index, pode ter mais de um
                    sw.WriteLine("Arquivo criado em: {0}", DateTime.Now.ToString());
                    sw.WriteLine("Autor: euzinha");
                    sw.WriteLine("Mais uma linha");
                    sw.WriteLine("Outra linha");
                    sw.WriteLine("Fim!");
                }

                Console.WriteLine("Arquivo criado com sucesso");
            }
            else
                Console.WriteLine("Arquivo já existe");
 
        }

        static void LerArquivo(string path, string file)
        {
            string caminho = path;
            string arquivo = file;
            string pathString = Path.Combine(caminho, arquivo);

            using (StreamReader sr = File.OpenText(pathString))
            {
                //Console.WriteLine(sr.ReadToEnd());

                //Ler enquanto linha não é nula, poderia usar outros delimitadores, como ;
                string s = "";
                while((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        static void DeletarArquivo(string path, string file)
        {
            string caminho = path;
            string arquivo = file;
            string pathString = Path.Combine(caminho, arquivo);

            if (File.Exists(pathString))
            {
                File.Delete(pathString);
                Console.WriteLine("Arquivo deletado com sucesso");
            }
            else
            {
                Console.WriteLine("Arquivo não existe");
            }
        }

        static void CopiarArquivo(string sourcePath, string sourceFile, string targetPath, string targetFile)
        {
            string caminhoOrigem = sourcePath;
            string arquivoOrigem = sourceFile;
            string sourcePathString = Path.Combine(caminhoOrigem, arquivoOrigem);

            string caminhoDestino = targetPath;
            string arquivoDestino = targetFile;
            string targetPathString = Path.Combine(caminhoDestino, arquivoDestino);

            

            if (!File.Exists(targetPathString))
            {
                File.Copy(sourcePathString, targetPathString);
                Console.WriteLine("Arquivo copiado com sucesso");
            }
            else
            {
                Console.WriteLine("Arquivo já existe");
            }

            static void MoverTodosArquivos(string sourcePath, string targetPath)
            {
                string origem = sourcePath;
                string destino = targetPath;

                if (Directory.Exists(sourcePath))
                {
                    string[] files = Directory.GetFiles(sourcePath);

                    foreach (string s in files)
                    {
                        string fileName = Path.GetFileName(s);
                        string destFile = Path.Combine(targetPath, fileName);
                        File.Copy(s, destFile, true);
                    }
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }

                Console.WriteLine("Sucesso");
            }

        }


        #endregion

    }

}
