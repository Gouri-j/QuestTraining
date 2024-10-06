using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine($"Enter the number {i + 1}: ");
                number[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    sum += number[i];
                }
                Console.WriteLine($"Sum of even numbers {sum}");

            }
        }
    }
}
