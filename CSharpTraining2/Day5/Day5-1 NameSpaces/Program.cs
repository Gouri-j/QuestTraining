using Day5_1_NameSpaces.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_1_NameSpaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringUtilities.ToUppercase("hello");
            MathUtilities.Add(1, 2);
            MathUtilities.Sub(1, 2);
        }
    }
}
