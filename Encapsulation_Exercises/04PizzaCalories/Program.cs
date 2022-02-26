using System;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] pizzaArgs = Console.ReadLine().Split(' ');
            Pizza pizza = new Pizza(pizzaArgs[1]);

            string[] doughArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dough dough = new Dough(doughArgs[1], doughArgs[2], int.Parse(doughArgs[3]));
            pizza.Dough = dough;

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] toppingArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Topping topping = new Topping(toppingArgs[1], int.Parse(toppingArgs[2]));
                pizza.AddTopping(topping);
            }

            Console.WriteLine(pizza);
        }
    }
}
