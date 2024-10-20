using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> startsWithA = str => str.StartsWith("A");
            Console.WriteLine(startsWithA("Apple"));
        }
    }
}
