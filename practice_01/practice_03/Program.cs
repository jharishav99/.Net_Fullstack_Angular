using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //printing values in 3 ways
            int cube;
            int forth_power = Printing(5, out cube);
            Console.WriteLine(cube);
            Console.WriteLine(forth_power);
        }
        static int Printing(int x, out int y)
        {
            Console.WriteLine(x * x);
            y = x * x * x;
            return x * x * x * x;
        }
    }
}
