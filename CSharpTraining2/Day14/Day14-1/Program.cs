using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_1
{
    abstract class Shape
    {
        public abstract double Area();
    }
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine($"Area :{circle.Area()}");
            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Area:{rectangle.Area()}");
        }
    }
}
