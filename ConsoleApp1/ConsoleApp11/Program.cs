using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone phone1 = new Smartphone();
            Smartphone phone2 = new Smartphone("Apple", "iPhone 15");
            Smartphone phone3 = new Smartphone("Samsung", "S24 Ultra", 512);
            phone1.DisplaySpecs();
            phone2.DisplaySpecs();
            phone3.DisplaySpecs();
            phone3.Send("Hello world!");
            phone3.Send("text", "ram");
            phone3.Send("message", "Admin", true);
        }
    }
}
