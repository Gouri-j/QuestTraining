using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>()
            {
                "Apple",
                "Orange",
                "Grapes",
                "Avocado",
                "Cherry"
            };
           
                var a = list.Where(i => i[0] == 'A');
                foreach (var i in a)
                {
                    Console.WriteLine(i);
                }
            
        }
    }
}
