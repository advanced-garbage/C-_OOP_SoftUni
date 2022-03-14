namespace Movies
{
    using System;
    using Adapter.AdapteeClasses;
    // A Program demonstrating the Adaptee Structural Pattern
    // The theme of this program will be about accessing random
    // movie facts, where we'll be making a Target class and an Adapter
    // class which will have access to the Adaptee class
    public class Program
    {
        static void Main()
        {
            Film film = null;
            Console.WriteLine($"Choose one of the following:");
            Console.WriteLine("1. Hard to be a God");
            Console.WriteLine("2. Sonatine");
            Console.WriteLine("3. Tetsuo: The Iron Man");

            switch(int.Parse(Console.ReadLine()))
            {
                case 1: film = new Film("Hard to be a God");
                    break;
                case 2: film = new Film("Sonatine");
                    break;
                case 3: film = new Film("Tetsuo: The Iron Man");
                    break;
                default: throw new ArgumentOutOfRangeException("Invalid option!");
            }

            film.Display();

            Console.ReadKey();
        }
    }
}