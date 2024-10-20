using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_16
{
    class Employee
    {
        public virtual void CalculateBonus() => Console.WriteLine("Calculate bonus");
    }
    class Manager : Employee
    {
        public override void CalculateBonus() => Console.WriteLine("Custom calculation");

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Employee e = new Manager();
            e.CalculateBonus();
        }
    }
}
