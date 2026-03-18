using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Publisher pub = new Publisher();
            Subscriber sub = new Subscriber();
            pub.OnClick += sub.React;
            pub.Click();
            Console.ReadKey();
        }
    }
}
