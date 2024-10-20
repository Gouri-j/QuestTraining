using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> printMessage = message => Console.WriteLine(message);
            printMessage("Welcome to the C# Action Delegate Example!");
        }
    }
}
