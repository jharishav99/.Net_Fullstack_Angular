using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Change(a);
            Console.WriteLine("Value type parameter (Default)");//5
            Console.WriteLine(a);//5

            int[] nums = { 1, 2 };
            Change_array(nums);
            Console.WriteLine("Reference type parameter"); 
            Console.WriteLine(nums[0]); // 99

            //output parameter
            int y;
            Getdata(out y);
            Console.WriteLine("Output paramter"); // 100
            Console.WriteLine(y); // 100


            
        }
        static void Change(int c) // default
        {
            int i = 10;
        }
        static void Change_array(int[] arr) // reference
        {
            arr[0] = 99;
        }

        static void Getdata(out int x) // output parameter 
        {
            x = 100;
        }
    }
}
