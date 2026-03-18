using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1("Male");
            Console.WriteLine(c.Greetings());
        }
    }
}
