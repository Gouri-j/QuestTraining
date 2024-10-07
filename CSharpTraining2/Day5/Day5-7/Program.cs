using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<string, List<int>>();

            while (true)
            {
                Console.WriteLine("Enter an ID or q to exit: ");
                var option = Console.ReadLine();
                if (option == "q")
                {
                    break;
                }
                if (d.ContainsKey(option))
                {
                    Console.WriteLine("Do you want to replace the mark : ");
                    var reply = Console.ReadLine();
                    if(reply.ToLower() != "yes")
                    {
                        continue;
                    }

                }
                var marks = new List<int>();
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"Enter mark {i}: ");
                    var mark = int.Parse(Console.ReadLine());
                    marks.Add(mark);
                }
                d.Add(option, marks);
            }
            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
            }
          Console.ReadKey();
        }
    }
}
