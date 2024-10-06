using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input");
            string input = Console.ReadLine();
            int sum = 0;
            int i = 0;
            while (i < input.Length)
            {
                int num = 0;
                while (i < input.Length && input[i] != '_')
                {
                    num = num * 10 + (input[i] - '0');
                    i++;
                }
                sum += num;
                i++;
            }
            Console.WriteLine($"Sum of numbers = {sum}");
        }
    }
}
