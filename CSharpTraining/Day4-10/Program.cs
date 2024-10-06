using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            string check = "";
            foreach (char c in input) 
            {
                if ("aeiouAEIOU".Contains(c))
                {
                    if(!check.Contains(c))
                    {
                        check += c;
                    }
                }
            }
            Console.WriteLine($"Vowels in string: {check}");
            Console.ReadKey();
        }
    }
}
