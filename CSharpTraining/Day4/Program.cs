using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Program
    {
        static float Add(float firstNumber, float secondNumber) => firstNumber + secondNumber;
        
        static float Sub(float firstNumber, float secondNumber) => secondNumber - firstNumber;

        static float Multiply(float firstNumber, float secondNumber) => firstNumber * secondNumber;
       
        static float Division(float firstNumber, float secondNumber)
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("Error");


            }
            else => firstNumber / secondNumber;
            
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number : ");
            float firstnumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            float secondnumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operator");
            char operatorChar = Console.ReadLine()[0];
            int  result = 0;
            while (true) 
            {
                switch(operatorChar)
                {
                    case '+':
                        result = Add(firstnumber , secondnumber)
                }
            
        }
        
    }
}
