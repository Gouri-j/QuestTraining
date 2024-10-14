using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the original array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr1 = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the new size for the resized array: ");
            int newSize = int.Parse(Console.ReadLine());
            int[] arr2 = new int[newSize];
            int elementsToCopy = Math.Min(arr1.Length, newSize);

            for (int i = 0; i < elementsToCopy; i++)
            {
                arr2[i] = arr1[i];
            }

            // Display the resized array
            Console.WriteLine("Resized Array:");
            foreach (int item in arr2)
            {
                Console.Write(item + " ");
            }
        }
    }
}
