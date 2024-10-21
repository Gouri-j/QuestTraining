using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 3, 4, 46, 89, 67, 1 };

            var output = list.Where(i => i > 50).ToList();
            if (output.Count > 0)
            {
                Console.WriteLine($"There are numbers greater than 50. They are: {string.Join(", ", output)}");
            }
            else
            {
                Console.WriteLine("The list contain no number greater than 50");
            }
        }
    }
}
