using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "HeLlO WoRlD";
            string[] res = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            { 
             if (input[i] >= 'A' &&  input[i] <= 'Z')
             {
                    res[i] = (input[i] + 32);
                       
             }
             else if (input[i] >= 'a' && input[i] <= 'z')
             {
                    res[i] = (input[i] - 32);
             }

            }
            foreach (string s in res)
            {
                Console.WriteLine(s);
            }
        }
    }
}
