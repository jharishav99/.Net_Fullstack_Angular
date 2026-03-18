using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            l.Add("Nepal");
            l.Add("US");
            l.Add("Germany");
            l.Add("Aus");
            l.Add("Germany");
            l.Add("Aus");
            
            

            foreach (string s in l)
            {
                Console.WriteLine(s);
            }
            l.Remove("Germany");
            l.RemoveAt(1);
            l.RemoveAll(e => e.Equals("Aus"));
            Console.WriteLine("After operations");
            foreach (string s in l)
            {
                Console.WriteLine(s);
            }
        }
    }
}
