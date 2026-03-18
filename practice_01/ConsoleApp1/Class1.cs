using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
    }

}
namespace App1.Myfolder
{
    public class Test
    {
        public Test() { Console.WriteLine("App1 constructor"); }
        public void Show() { Console.WriteLine("App1 show"); }
    }
}
namespace App2.Myfolder
{
    public class Test
    {
        public Test() { Console.WriteLine("App2 constructor"); }
        public void Show() { Console.WriteLine("App2 show"); }
    }
}

