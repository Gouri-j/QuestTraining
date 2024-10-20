using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = n => n % 2 == 0;
            int number1 = 4;
            int number2 = 7;
            Console.WriteLine($"{number1} is even: {isEven(number1)}");
            Console.WriteLine($"{number2} is even: {isEven(number2)}");
        }
    }
}
