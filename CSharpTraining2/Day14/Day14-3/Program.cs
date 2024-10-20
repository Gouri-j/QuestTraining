using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_3
{
    internal interface IAnimal
    {
        void Speak();
    }
    class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("The cat says Meow");
        }
    }
    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("The dog says Bow");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal Dog = new Dog();
            IAnimal Cat = new Cat();
            Dog.Speak();
            Cat.Speak();
        }
    }
}
