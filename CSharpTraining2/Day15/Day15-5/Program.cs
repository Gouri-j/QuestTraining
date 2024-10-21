using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = new List<int>() { 4, 3, 7, 5, 2 };
            var res = number.Where(i => i % 2 == 0).Select(i => i * i);
            foreach (int item in res)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
