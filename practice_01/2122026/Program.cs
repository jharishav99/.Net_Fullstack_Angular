using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2122026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "apple , orange, mango";
            string[] slice = word[5..].Split(',');
            char val = word[^2];
            Console.WriteLine(val);
        }
    }
}
