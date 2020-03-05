using System;

namespace Aula10
{
    class Principal
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("# Semaforo #");
            //Console.WriteLine(Semaforo.Vermelho);
            //Console.WriteLine((int)Semaforo.Vermelho);

            //Console.WriteLine(Semaforo2.Amarelo);
            //Console.WriteLine((int)Semaforo2.Amarelo);

            //Semaforo cor = Semaforo.Amarelo;
            //Console.WriteLine("A cor do semáforo é: " + cor);


            //Console.WriteLine("##### TIPOS DE CONTA ####");
            //Console.WriteLine(TipoConta.ContaCorrente + ": " + (int)TipoConta.ContaCorrente);
            //Console.WriteLine(TipoConta.ContaUniversitaria + ": " + (int)TipoConta.ContaUniversitaria);
            //Console.WriteLine(TipoConta.ContaMax + ": " + (int)TipoConta.ContaMax);
            //Console.WriteLine(TipoConta.ContaAposentado + ": " + (int)TipoConta.ContaAposentado);


            // para codigo que pode dar erro, usar o try

            string[] a = new string[3];

            try
            {
                Console.WriteLine(a[10]);
            }
            catch (Exception e) //executa quando o try dá erro - exception especifica o erro
            {
                Console.WriteLine("Erro: " + e.Message + " "+ e.StackTrace);
            }

            Console.WriteLine("Continua");


        }
    }

    // enum é uma classe para guardar constantes. Funciona como uma classe estática

    //o enum abaixo funciona de forma parecida com um dicionário, ele define automaticamente um número para cada item.    
    enum Semaforo
    {
        Amarelo,
        Verde,
        Vermelho
    }

    //também é possível definir números para cada

    enum Semaforo2
    {
        Amarelo = 100,
        Verde = 200,
        Vermelho = 300
    }

    class Rua
    {
        public string Nome { get; set; }
        public Semaforo cor { get; set; }
    }

    enum TipoConta
    {
        ContaCorrente = 0,
        ContaUniversitaria = 1,
        ContaMax = 2,
        ContaAposentado = 3
    }
}
