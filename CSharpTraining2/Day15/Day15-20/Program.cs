using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Sam", "Ann", "Riya" };
            List<int> ages = new List<int> { 20, 22, 35 };
            var res = names.Zip(ages, (name, age) => new { Name = name, Age = age }).ToList();
            foreach (var item in res)
            {
                Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
            }
        }
    }
}
