using C1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myOtherCar = new Car("Kia");
            Console.WriteLine("Accessing C1 from C2!");
            myOtherCar.Drive();
            
        }
    }
}
