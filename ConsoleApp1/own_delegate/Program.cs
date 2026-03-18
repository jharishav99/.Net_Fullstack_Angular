using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace own_delegate
{
    public delegate void MyDelegate(int x);
    internal class Program
    {
        static void Main(string[] args)
        {
            DelegatesExample de = new DelegatesExample();
            MyDelegate myd = new MyDelegate(de.MyMethod);
            myd.Invoke(10);
            Predicate<int> pred = de.Eligible;
            bool check = pred.Invoke(81);
            string msg = check == true ? "Eligible" : "Rejected";
            Console.WriteLine(msg);
        }
    }
    public class DelegatesExample
    {
        public void MyMethod(int x)
        {
            Console.WriteLine($"MyMethod called with value: {x}");
        }

        public bool Eligible(int marks)
        {
            if (marks > 80)
            { return true; }
            else return false;
        }
    }
}
