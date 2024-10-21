using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 2, 3, 8, 9, 10 ,11,3,6};

            var result = numbers.Skip(5).Take(3).ToList();
            Console.WriteLine($"Result: {string.Join(", ", result)}");
        }
    }
}
