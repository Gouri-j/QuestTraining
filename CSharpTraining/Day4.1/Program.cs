using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4._1
{
    internal class Program
    {
        static int Add(int num1, int num2) => num1 + num2;
        static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Div(int num1, int num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation to be performed from + , - , * , /  ");
            char operation = Console.ReadLine()[0];
            switch (operation)
            {
                case '+':
                    Console.WriteLine(Add(num1, num2));
                    break;
                case '-':
                    Console.WriteLine(Sub(num1, num2));
                    break;
                case '*':
                    Console.WriteLine(Mul(num1, num2));
                    break;
                case '/':
                    Console.WriteLine(Div(num1, num2));
                    break;
                default:
                    Console.WriteLine("Enter a valid expression");
                    break;
            }
        }
    }
}
