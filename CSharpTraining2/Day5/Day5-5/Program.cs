using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter number {i + 1}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                { 
                    list.Remove(i);
                }
            }
            Console.WriteLine(string.Join(",", list));
        }
    }
}
