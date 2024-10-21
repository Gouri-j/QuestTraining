using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 12, 34, -5, 6, -3 };

            var res = list.Where(x => x < 0);
            if (res.Count() > 0)
            {
                Console.WriteLine("The list contain Negative numbers");
            }
            else
            {
                Console.WriteLine("The list contains only positive numbers");
            }
        }
    }
}
