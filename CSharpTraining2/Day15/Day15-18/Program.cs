using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<(string Name, decimal Price)>
        {
            ("Laptop", 500),
            ("Tv", 150),
            ("Fridge", 25),
            
        };

            var res = products
                .Where(p => p.Price > 100)
                .OrderBy(p => p.Price)
                .ToList();

            foreach (var product in res)
            {
                Console.WriteLine($"{product.Name}: ${product.Price}");
            }
        }
    }
}
