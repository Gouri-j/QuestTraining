using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "John", "David", "Michael" };
            Console.WriteLine("Enter a name : ");
            string toSearch = Console.ReadLine().ToLower().Trim();
            for (int i = 0; i < names.Length; i++)
            {
              
               if (names.Contains(toSearch.ToLower()))
               {
                  Console.WriteLine("The name exists");
               }
               else
               {
                  Console.WriteLine("The name does not exist");
               }
            }
        }
    }
}
