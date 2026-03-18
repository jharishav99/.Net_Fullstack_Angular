using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp9.NewFolder1;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number :- ");
            int number = int.Parse(Console.ReadLine());

            math myCalc = new math();

            int cubeResult;
            int finalResult = myCalc.Printing(number, out cubeResult);

            Console.WriteLine($"Cube: {cubeResult}");
            Console.WriteLine($"Quad: {finalResult}");

           


        }
    }
}
