using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 21, 5, 87, 56, 4, 9 };

            var greaterThanTen = list.Where(x => x > 10);

            var res = greaterThanTen.Count();

            Console.WriteLine(res);
        }
    }
}
