using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car("Toyota");
            Console.WriteLine("My car is a: " + myCar.Model);
            myCar.Drive();
            Console.ReadLine();
        }
    }
}
