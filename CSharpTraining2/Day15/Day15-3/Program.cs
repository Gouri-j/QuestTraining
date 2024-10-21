using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {3,9,4,1,7,6,0 };

            var res = numbers.OrderByDescending(x => x);
            foreach (var number in res)
            {
                Console.WriteLine(number);
            }
        }
    }
}
