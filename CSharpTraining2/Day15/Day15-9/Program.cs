using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 10, 25, 34, 46, 78 };             
            var res = numbers.Max();
            Console.WriteLine(res);
        }
    }
}
