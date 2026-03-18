using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dict
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Nepal");
            d.Add(2, "US");
            d.Add(3, "Aus");
            d.Add(4, "Germany");

            foreach(KeyValuePair<int,string> kv in d)
            // foreach(var kv in d)
            // can use var instead of  KeyValuePair<int,string>
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}
