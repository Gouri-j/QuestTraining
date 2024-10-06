using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "MALAYALAM";
            var reverse = string.Concat(text.Reverse());
            if(text == reverse)
            {
                Console.WriteLine("Same");
            }
        }
    }
}
