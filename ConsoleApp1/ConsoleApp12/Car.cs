using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Car
    {
        public int ModelNo { get; set; }
        public string Color { get; set; }
        public string Steering { get; set; }
        public float FuelCapacity{ get; set; }
    
        public virtual void Discount()
        {
            Console.WriteLine("No discount");
        }
    }
    public class Maruti : Car
    {
        public override void Discount()
        {
            Console.WriteLine("You have 10% discount");
        }
        public void M1()
        {

        }
    }



}
