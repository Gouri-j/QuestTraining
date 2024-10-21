using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dup = new List<int>() { 1, 3, 7, 3, 1 };

            var dist = dup.Distinct().ToList();

            Console.WriteLine(string.Join(", ", dist));
        }
    }
}
