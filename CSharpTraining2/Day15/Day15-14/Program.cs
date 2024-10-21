using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<float>() { 1, 2.3F, 6.5F, 4 };

            var avg = numbers.Average();

            Console.WriteLine(avg);
        }
    }
}
