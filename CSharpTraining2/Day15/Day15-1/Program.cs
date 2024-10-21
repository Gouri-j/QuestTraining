using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<int>() { 1, 2, 4, 5, 7, 8, 3, 6, 9 };
            var res = lst.Where(i => i % 2 == 0);
            foreach (var i in res) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
