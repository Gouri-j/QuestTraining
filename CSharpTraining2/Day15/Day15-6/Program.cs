using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>()
            {
                "Ball",
                "Toys",
                "Gun",
                "Bat",
            };
            var firstItem = list.FirstOrDefault(i => i[0] =='B');

            if (firstItem != null)
            {
                Console.WriteLine(firstItem);
            }
            else
            {
                Console.WriteLine("null");
            }
        }
    }   
}
