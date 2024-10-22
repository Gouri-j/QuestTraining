using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class DictionaryOp<Tkey, Tvalue>
    {
        public Dictionary<Tkey, Tvalue> data = new Dictionary<Tkey, Tvalue>();

        public int Count => data.Count;
        public void Add(Tkey key, Tvalue value)
        {
            data.Add(key, value);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new DictionaryOp<string,string>();
            data.Add("Name", "Gouri");
        }
    }
}
