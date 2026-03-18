using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOperations ao = new ArithmeticOperations();

            int x1 = 5;
            int y1 = 3;

            int x2 = 3;
            int y2 = 5;

            int result1 = ao.Calculate1(x1, y1);
            Console.WriteLine(x1);  // 5  not changed
            Console.WriteLine(result1); // 18 (5+10+ 3 = 18 )


            int result2 = ao.Calculate2(ref x2, y2); // need to add ref here too.
            Console.WriteLine(x2);  // 13 (cause 3+10)  
            Console.WriteLine(result2); // (13+5=18)


        }
        class ArithmeticOperations
        {
            public int Calculate1(int x1, int y1) // without ref (value types doesn't change)
            {
                x1 = x1 + 10;
                return x1 + y1;
            }

            public int Calculate2(ref int x2, int y2) // with ref (value type will be changed)
            {
                x2 = x2 + 10;
                return x2 + y2;
            }
        }
    }
}
