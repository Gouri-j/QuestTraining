using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Day15_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>() { "Note", "Pen", "Bag", "Scale", "Text" };
            var res = list.GroupBy(x => x.Length);
            foreach (var item in res)
            {
                Console.WriteLine($"Length{item.Key}: {string.Join(",", item)}");
            }
        }
    }
}
