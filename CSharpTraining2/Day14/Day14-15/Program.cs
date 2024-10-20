using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_15
{
    class Animal
    {
        public virtual void MakeSound() => Console.WriteLine("Makes sound");
    }
    class Dog : Animal
    {
        public override void MakeSound() => Console.WriteLine("Bark");

    }
    class Program
    {
        public static void Main(string[] args)
        {
            var d = new Dog();
            d.MakeSound();
        }
    }
}
