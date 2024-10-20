using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_6
{
    delegate void PrintMessage(string message);
    internal class Program
    {
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            PrintMessage print = DisplayMessage;
            Console.WriteLine("Hello, this is a delegate example!");
        }
    }
}
