using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_5
{
 
   delegate int operation(int a, int b);
   internal class Program
   {

     static int Add(int a, int b)
     {
         return a + b;
     }

     static int Multiply(int a, int b)
     {
         return a * b;
     }
     static void Main(string[] args)
     {
         operation addOperation = Add;
         operation multiplyOperation = Multiply;
         int addResult = addOperation(10, 5);
         Console.WriteLine($"Addition Result: {addResult}");
         int multiplyResult = multiplyOperation(10, 5);
         Console.WriteLine($"Multiplication Result: {multiplyResult}");
     }
   }
}
