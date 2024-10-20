using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = (x, y) => x + y;
            int result = add(5, 10);
            Console.WriteLine("The sum of 5 and 10 is: " + result);
        }
    }
}
