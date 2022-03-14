using System;
using ProxyRealLifeExample.ProxyClasses;

namespace ProxyRealLifeExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create math proxy
            MathProxy mp = new MathProxy();

            // Initialize the methods through proxy, which
            // in turn will call the real subject method
            Console.WriteLine($"4 + 2 = {mp.Add(4, 2)}");
            Console.WriteLine($"4 - 2 = {mp.Sub(4, 2)}");
            Console.WriteLine($"4 * 2 = {mp.Mul(4, 2)}");
            Console.WriteLine($"4 / 2 = {mp.Div(4, 2)}");

            Console.ReadKey();
        }
    }
}
