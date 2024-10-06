using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Name 1", "Name 2", "Name 3" };
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < names.Length; i++)
            { 
                res.AppendLine($"{names[i]} is {i} years old.");
            }
            Console.WriteLine(res.ToString());
        }
    }
}
