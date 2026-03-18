using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            App1.Myfolder.Test a = new App1.Myfolder.Test();
            a.Show();
            App2.Myfolder.Test b = new App2.Myfolder.Test();
            b.Show();
        }
    }
}
