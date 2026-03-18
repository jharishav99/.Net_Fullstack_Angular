using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname = "Rishav";
            string sname = "Jha";

            // + Operator
            string plusMethod = fname + " " + sname;
            Console.WriteLine("Plus Operator: " + plusMethod);

            // Placeholders
            string placeholderMethod = string.Format("{0} {1}",fname, sname);
            Console.WriteLine("Placeholder:   {0}", placeholderMethod);

            // String Interpolation
          
            string interpolationMethod = $"{fname} {sname}";
            Console.WriteLine($"Interpolation: {interpolationMethod}");
        }
    }
}
