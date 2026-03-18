using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    public class Car
    {
        public string Model;

        public Car(string modelName) // parameterized constructor
        {
            Model = modelName;
        }
        public void Drive()
        {
            Console.WriteLine(Model+ " driving now!");
        }
    }
}
