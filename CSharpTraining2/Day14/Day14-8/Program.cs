using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> getStringLength = str => str.Length;
            string input = "Hello, World!";
            int length = getStringLength(input);
            Console.WriteLine($"The length of the string \"{input}\" is: {length}");
        }
    }
}
