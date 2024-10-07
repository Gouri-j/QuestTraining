using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_3Object
{
    internal class Program
    {
       /* static void DoThis(object a, object b);
        {
          if(a.GetType() == typeof(string)
          {
             string s1 = (string)a;
             string s2 = (string)b;
             Console.WriteLine(s1 + " " + s2);
        
          }
          else if(a.GetType() == typeof(int))
          {
            int i1 = (int)a;
            int i2 = (int)b;
            Console.WriteLine(i1 + i2);
        }*/
        static void Main(string[] args)
        {
            object obj = 1;
            string s = "Hello";
            Console.WriteLine(obj.GetType());
            Console.ReadKey();
        }
    }
}
