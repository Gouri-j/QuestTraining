using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_14
{
    abstract class Person
    {
        public abstract void Work();
    }
    class Doctor : Person
    {
        public override void Work()
        {
            Console.WriteLine("The doctor examines patients and prescribes treatment.");
        }
    }
    class Engineer : Person
    {
        public override void Work()
        {
            Console.WriteLine("The engineer designs and builds structures or systems.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person myDoctor = new Doctor();
            Person myEngineer = new Engineer();
            myDoctor.Work();
            myEngineer.Work();
        }
    }
}
