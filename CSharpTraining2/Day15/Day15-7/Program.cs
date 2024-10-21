using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stud = new List<string>() { "John", "Sam", "Riya" };
            var score = new List<int>() { 85, 60, 78 };

            Dictionary<string, int> grade = new Dictionary<string, int>();
            for (int i = 0; i < stud.Count; i++) 
            {
                grade.Add(stud[i], score[i]);
            }
            var res = grade.Where(i => i.Value >80).Select(i => i.Key).ToList();
            Console.WriteLine(string.Join("/n",res));

        }
    }
}
