using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DelegatesExample de = new DelegatesExample();
            Predicate<int> pred = de.Eligible;
            bool check = pred.Invoke(81);
            string msg = check == true ? "Eligible" : "Rejected";
            Console.WriteLine(msg); 
        }
    }
    public class DelegatesExample
    {

        public bool Eligible(int marks)
        {
            if (marks > 80)
            { return true; }
            else return false;
                    }
    }

    }
