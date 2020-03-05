using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Aulas
{
    class Prinicpal
    {
        //assume a permissao da classe se não definido
        //é pouco utilizada, mas pode ser interessante em alguns casos
        //é interessante quando o valor é fixo e usado em vários lugares
        //é arriscado, pois qualquer um poderia mexer e mudar
        //para se prevenir é possível usa const
        // public const int 
        //outro igual ao const (constante) é o readonly
        //public readonly string
        // a diferença é que o readonly consegue mudar apenas quando instacia a classe pela primeira vez e a partir desse momento ele não muda mais
        //readonly é usado para criar uma chave única - por ex. id, cpf
        //readonly não pode ser definido dentro de uma classe estatica

        static string varGlobal = "";

        static void Main()
        {

            string varMain = "Main";
            string varGlobal = "Global";

            //Exer1();
            //Exer2();


            // classe estática é muito utilizado quando é sempre igual

            //instanciar classe
            //Classe sem construtor
            //ContaBancaria contaBancaria = new ContaBancaria();
            //contaBancaria.nome = "Gabi";
            //contaBancaria.cpf = 391746678;
            //contaBancaria.email = "gabrieladischinger@gmail.com";
            //contaBancaria.saldo = 10;


            ContaBancaria contaBancaria = new ContaBancaria(1, "Gabi", 391746678, "gabrieladischinger@gmail.com", 10);
            contaBancaria.ImprimirDados();


            //classe estáticas não é necessário instacia-la
            //contaBancaria.SetSaldo(Investimento.Investimento01(12, contaBancaria.GetSaldo()));

            contaBancaria.Saldo = Investimento.Investimento01(12, contaBancaria.Saldo);
            Console.WriteLine(contaBancaria.Saldo.ToString("C"));

            Console.WriteLine("\n\n-------APOS 12 MESES DE INVESTIMENTOS");
            contaBancaria.ImprimirDados();

            Console.WriteLine(contaBancaria.id);

            //também é possível passar parametros em classes, chamados construtores
        }

        //se a variável não for global, variaveis com mesmo nome não são a mesma coisa

        static void Method()
        {
            varGlobal = "Global2";
        }

        #region Exercicos
        static void Exer1 ()
        {
            Console.WriteLine("Digite a quantidade de vezes que gostaria de imprimir menor ou igual a 10: ");
            int repeticoes = Convert.ToInt32(Console.ReadLine());

            while (repeticoes == 0 || repeticoes > 10)
            {
                Console.WriteLine("Digite a quantidade de vezes que gostaria de imprimir menor ou igual a 10: ");
                repeticoes = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < repeticoes; i++)
            {
                Console.WriteLine("Hello World");
            }
        }

        static void Exer2 ()
        {
            int[] array = { 10, 20, 30, 40, 50 };
            int[] div10 = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                div10[i] = array[i] / 10;
            }

            foreach (int item in div10)
            {
                Console.WriteLine(item);
            }
        }

        #endregion
    }

    #region Classes
    class ContaBancaria
    {
        // digitar ctro para criar construtores
        //construtores tem o mesmo nome que a classe
        // só se acessa o construtor quando a classe é instaciada
        // roda autamento ao criar um new no main

        //public string nome;
        //public int cpf;
        //public string email;
        //public double saldo;

        //ainda será possível acessar as variaveis do main se forem mantidas como publicas
        //para que isso não seja possível, é só tornar as variáveis como privadas

        public readonly double id;
        private string nome;
        private int cpf;
        private string email;
        private double saldo;

        //verificar e atualizar saldo também pode ser feito através de propriedades
        //propriedades são mais complexas - sempre com inicio em letra maiuscula
        //prop tab tab
        public double Saldo
        {
            get
            {
                return saldo;
            }
            //set pode ser definido como private
            set
            {
                saldo = value;
            }
        }

        public ContaBancaria(double i, string n, int c, string e, double s)
        {
            id = i;
            nome = n;
            cpf = c;
            email = e;
            saldo = s;
        }

        // é possível ter mais de um construtor e aparecerão as duas opcoes no momento do preenchimento
        public ContaBancaria()
        {

        }

        //public double GetSaldo()
        //{
        //    return saldo;
        //}
        
        //public void SetSaldo(double v)
        //{
        //    saldo = v;
        //}

        
        

        public void ImprimirDados ()
        {
            Imprimir();
        }

        //Método privado só pode ser acessado dentro daquela mesma classe, só pode ser acessado indiretamente por outras.
        private void Imprimir()
        {
            //outra forma de concatenar, colocando a variável dentro {}
            Console.WriteLine($"\nNome: {nome} \nCPF: {cpf} \nE-mail: {email} \nSaldo: {Saldo.ToString("C")} \nID: {id}");
        }

    }

    static class Investimento
    {

        public const double aliquota = 1.1;
        public static double Investimento01 (int prazo, double valor)
        {
            return valor * prazo * aliquota;
        }

        public static double Investimento02 (int prazo, double valor)
        {
            return valor * prazo * aliquota;
        }

        public static double Investimento03 (int prazo, double valor)
        {
            return valor * prazo * aliquota;
        }
    }

    #endregion
}
