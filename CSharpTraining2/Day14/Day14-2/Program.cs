using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_2
{
    abstract class Vehicle
    {
        public int speed { get; set; }
        public abstract void Drive();
    }
    class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"Driving a car with speed:{speed}");
        }
    }
    class Bicycle : Vehicle
    {
        public override void Drive()
        {
              Console.WriteLine($"Driving Bicycle with speed :{speed}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var Car = new Car();
            Car.speed = 100;
            var Bicycle = new Bicycle();
            Bicycle.speed = 120;
            Car.Drive();
            Bicycle.Drive();
        }
    }
}
