using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO");
            Console.WriteLine("Hi"); // writeline -> creates a new line
            Console.Write("3rd");    // write -> doesn't creates a new line 
            Console.Write("4th");

            String name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine()); // parse=throw exceptions on failure 
            // TryParse = returns boolean

            Console.WriteLine(name);
            Console.WriteLine(age);

            string mobile = "samsung";
            Console.WriteLine($"My mobile brand is of :- {mobile}");

        }
    }
}
