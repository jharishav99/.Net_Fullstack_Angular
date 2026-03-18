using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add(100);
            myList.Add(300);
            myList.Add("Hello");
           // int val = int.Parse(myList[0].ToString());
            for(int i=0; i<myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

        }
    }
}
