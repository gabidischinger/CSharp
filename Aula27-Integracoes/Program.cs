using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Integracao;
using Newtonsoft.Json;

namespace Aula27_Integracoes
{
    class Program
    {
        static void Main()
        {
            //DllviaReferencia();
            //DllviaReflection();
            //APIString();

            //APIJsonAsync().Wait();

            APIStarWars().Wait();
        }

        static void DllviaReferencia()
        {
            //Clicar com o botão direito, adicionar referência, procurar
            Console.WriteLine("Integração via Referência");
            Class1 classe = new Class1();
            string txt = classe.RetornarString();
            Console.WriteLine(txt);
            Console.WriteLine();
            Console.WriteLine();
        }

        static void DllviaReflection()
        {
            // Carrega dll
            Assembly testAssembly = Assembly.LoadFile(@"D:\OneDrive\Estudos\Pi\Repositorio\CSharp\Aula27-Integracoes\dll\Integracao.dll");

            // Carrega namespace e classe
            Type exterType = testAssembly.GetType("Integracao.Class1");

            // Cria instancia da classe
            object exterInstancia = Activator.CreateInstance(exterType);

            // Carrega metodo
            MethodInfo method = exterType.GetMethod("RetornarString");

            // Adiconada metodo
            var r = method.Invoke(exterInstancia, null) as string;

            Console.WriteLine("Integração via Reflection");
            Console.WriteLine(r);
        }

        static void APIString()
        {
            Console.WriteLine("API");
            //http://dummy.restapiexample.com/api/v1/employees

            using (var cliente = new WebClient())
            {
                var result = cliente.DownloadString("http://dummy.restapiexample.com/api/v1/employees"); //URI
                Console.WriteLine(Environment.NewLine + result);
            }
        }

        public static async Task APIJsonAsync()
        {
            Console.WriteLine("API");
            //http://dummy.restapiexample.com/api/v1/employees

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://dummy.restapiexample.com/");

                var response = await client.GetAsync("api/v1/employees");

                var data = response.Content.ReadAsStringAsync().Result;

                //Console.WriteLine(data);

                var result = JsonConvert.DeserializeObject<Empregados>(data);

                Console.WriteLine($"Status: {result.Status}");

                foreach (var item in result.Data)
                {
                    Console.WriteLine($"{item.Employee_name}\n{item.Employee_age}\n{item.Employee_salary}\n");
                }

            }

        }

        public static async Task APIStarWars()
        {
            Console.WriteLine("API StarWars");

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://swapi.co/api/");

                var response = await client.GetAsync("people/1/");

                var data = response.Content.ReadAsStringAsync().Result;

                //Console.WriteLine(data);

                var result = JsonConvert.DeserializeObject<StarWars>(data);

                Console.WriteLine($"Nome: {result.Name}");
                Console.WriteLine($"Altura: {result.Height}");
                Console.WriteLine($"Massa: {result.Mass}");
                Console.WriteLine($"Cor do cabelo: {result.Hair_color}");
                Console.WriteLine($"Cor da pele: {result.Skin_color}");
                Console.WriteLine($"Cor do olho: {result.Eye_color}");
                Console.WriteLine($"Nascimento: {result.Birth_year}");
                Console.WriteLine($"Genero: {result.Gender}");

            }
        }
    }

    public class Empregados
    {
        //só a classe não precisa, pois no Json não tem a definição da classe

        public string Status { get; set; }
        public List<Empregado> Data { get; set; }
    }

    public class Empregado
    {
        //tem que bater com o JSon
        public string Id { get; set; }
        public string Employee_name { get; set; }
        public string Employee_salary { get; set; }
        public string Employee_age { get; set; }
        public string Profile_image { get; set; }

    }

    public class StarWars
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string Hair_color { get; set; }
        public string Skin_color { get; set; }
        public string Eye_color { get; set; }
        public string Birth_year { get; set; }
        public string Gender { get; set; }

    }

}
