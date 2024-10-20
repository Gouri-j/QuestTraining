using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_13
{
    abstract class Appliance
    {
        public abstract void TurnOn();
    }
    class Fan : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("The fan is now ON.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Appliance myFan = new Fan();
            myFan.TurnOn();
        }
    }
}
