using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.NewFolder1
{
    internal class math
    {
        public int Printing(int x,out int y)
        {
            //y = 0; // here if we have out varaible we either need to remove or assign 0;
            //int[] results = new int[3];
            //results[0] = x * x;
            //results[1] = x * x * x;
            //results[2] = x * x * x;

            Console.WriteLine(x * x);
            y = x * x * x;
            return x*x*x*x;
        }
    }
}
