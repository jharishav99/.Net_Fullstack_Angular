using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameter_second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area a1 = new Area(10); // 10*10=100
            Area a2 = new Area(10,20); // 10*20=200
            Console.WriteLine(a1.Mycalc());
            Console.WriteLine(a2.Mycalc());
        }
    }
}
