using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<List<int>>();

            for (int i = 0; i < 2; i++)
            {
                var marks = new List<int>();
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"Enter mark {j} : ");
                    int mark = int.Parse( Console.ReadLine() );
                    marks.Add( mark );
                }
                data.Add( marks );
            }
            Console.ReadKey();
            foreach (var item in data)
            {
                Console.WriteLine(string.Join(",",item));
            }
        }
    }
}
