using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_17
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<string>
            {
                "Sam",
                "John",
                "Riya"
            };
            var empId = new List<int> { 101, 201, 301 };
           
            var departments = new List<string>
            {
                "CSE",
                "Mechanical",
                "Electronics"
            };
            for (int i = 0; i < empId.Count; i++)
            {
                Console.WriteLine($"{employees[i]} - {departments[i]}");
            }

        }
    }
}

