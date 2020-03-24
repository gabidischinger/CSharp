using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula18___LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> oList = new List<string>();
            oList.Add("Vegeta");
            oList.Add("Cyber");
            oList.Add("Goku");
            oList.Add("Shiryu");


            //Select (Contains)
            var result = oList.Select(x => x == "Goku");
            Console.WriteLine(result);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            // Where return list (Selecionar apenas)
            var result2 = oList.Where(s => s == "Goku");
            Console.WriteLine(result2);
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }


            // Where return one
            var result3 = oList.Where(s => s == "Goku").FirstOrDefault();
            Console.WriteLine(result3);


            // FindAll
            List<int> numeros = new List<int>();
            numeros.Add(1);
            numeros.Add(3);
            numeros.Add(-1);
            numeros.Add(-5);

            var resul4 = numeros.FindAll(n => n > 0);
            //var resul4 = numeros.Where(n => n > 0).ToList();

            foreach (var item in resul4)
            {
                Console.WriteLine(item);
            }


            // Filtrar classes compelxas
            List<Car> cars = new List<Car>
            {
                new Car{ Name = "Audi", Preco=52642 },
                new Car{ Name = "Mercedes", Preco=57127 },
                new Car{ Name = "Skoda", Preco=9000 },
                new Car{ Name = "Volvo", Preco=29000 },
                new Car{ Name = "Bentley", Preco=350000 },
                new Car{ Name = "Citroen", Preco=21000 },
                new Car{ Name = "Hummer", Preco=41400 },
                new Car{ Name = "Volkswagen", Preco=21600 }
            };
            var result5 = cars.Where(c => c.Preco > 9000 && c.Preco < 50000).Select(c => new { c.Name });
            //var result5 = cars.Select(c => new { c.Name });

            foreach (var car in result5)
            {
                Console.WriteLine($"{car.Name}");
                //Console.WriteLine($"{car.Name} {car.Preco}");
            }
        }

        public class Car
        {
            public string Name { get; set; }
            public int Preco { get; set; }
        }
    }
}
