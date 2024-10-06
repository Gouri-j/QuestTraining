using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            for (int row = 1; row <= 4; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
