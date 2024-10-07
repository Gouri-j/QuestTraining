using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_4List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            //Add a single element
            list.Add(10);

            //Adding multiple values.
            var valuesToAdd = new int[] { 20, 30, 40, 50, 50 };
            list.AddRange(valuesToAdd);

            //Updating the element.
            list[0] = 100;

            //Deletinf or removing the first occurance of 50
            list.Remove(50);

            // Remove from a specific index.
            list.RemoveAt(1);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] + ",");

            }
        }
    }
}
