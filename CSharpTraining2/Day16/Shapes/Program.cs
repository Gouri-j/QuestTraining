using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    interface Ishape
    {
        double GetArea();
        double GetPerimeter();
    }
    class Circle : Ishape
    {
        public double Radius { get; set; }
        public double GetArea() => Math.PI * Radius * Radius;
        public double GetPerimeter() => 2 * Math.PI * Radius;
    }
    class Rectangle : Ishape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double GetArea() => Length * Width;
        public double GetPerimeter() => (2 * Length) + (2 * Width);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Ishape>
            {
                new Circle {Radius = 10 },
                new Rectangle {Length = 10, Width = 15}
            };
            foreach (var item in shapes)
            {
                Console.WriteLine($"Area : {item.GetArea()},Perimeter : {item.GetPerimeter()}");
            }
        }
    }
}
