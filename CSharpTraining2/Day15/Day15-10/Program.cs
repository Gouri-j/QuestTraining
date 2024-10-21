using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 8,6,45,1,3 };
            var res = numbers.Min();
            Console.WriteLine(res);
        }
    }
}
