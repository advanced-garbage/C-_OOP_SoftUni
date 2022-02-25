using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            var products = new List<Product>();
            string[] peopleArr = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] productsArr = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach(var p in peopleArr)
            {
                var data = p.Split('=');
                string name = data[0]; 
                int money = int.Parse(data[1]);
                Person currentPerson = new Person(name, money);
                people.Add(currentPerson);
            }

            foreach (var p in productsArr)
            {
                var data = p.Split('=');
                string name = data[0];
                int cost = int.Parse(data[1]);
                Product currentProduct = new Product(name, cost);
                products.Add(currentProduct);
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = data[0];
                string product = data[1];

                Person currentPerson = people.Find(x => x.Name.Equals(name));
                Product currentProduct = products.Find(x => x.Name.Equals(product));
                currentPerson.AddProduct(currentProduct);
            }

            foreach (var p in people)
            {
                if (p.Products.Any())
                {
                    Console.WriteLine(p.PrintProducts());
                }
                else
                    Console.WriteLine($"{p.Name} - Nothing bought");
            }
        }
    }
}
