using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. string vs stringbuilder
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Rishav");
            sb.AppendLine("Jha");
            Console.WriteLine(sb.ToString()); // ToString is used to convert the StringBuilder obj into string

            // 2. Types of c#
            // a. Value types
            int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine(a); // 10
            Console.WriteLine(b); // 20

            // b. reference types
            Person p1 = new Person();
            p1.Name = "ram";
            Person p2 =p1;
            p2.Name = "shyam";
            Console.WriteLine(p1.Name); //shyam
            Console.WriteLine(p2.Name); // shyam

            // implicit and explicit
            int x = 10;
            double y = a;
            Console.WriteLine(x); // 10
            Console.WriteLine(y); // 10

            double x1 = 10.5;
            int y1 = x;
            Console.WriteLine(x1); // 10.5
            Console.WriteLine(y1); // 10

            // parsing
            string s = "123";
            int num = int.Parse(s);
            Console.WriteLine("Parsing");
            Console.WriteLine(num); // 123


            // TryParse -> best for practicing  , no exception and returns true/false;
            Tryparse_example();
            
        }
        class Person
        {
            public string Name;
        }
        static void Tryparse_example()
        {
            string abc = "123";
            int num;
            bool success = int.TryParse(abc, out num);

            Console.WriteLine("TryParsing");
            if (success)
            {
                Console.WriteLine(abc);
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }

    }
}
