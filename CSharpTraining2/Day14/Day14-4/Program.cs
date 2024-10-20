using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_4
{
    interface ICalculator
    {
        int Add(int a, int b);
        int Sub(int a, int b);
    }
    class SimpleCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalculator simplecalculator = new SimpleCalculator();
            int resultAdd = simplecalculator.Add(1, 2);
            Console.WriteLine(resultAdd);
            int resultSubtract = simplecalculator.Sub(3, 1);
            Console.WriteLine(resultSubtract);
        }
    }
}
