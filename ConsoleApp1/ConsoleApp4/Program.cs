using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArithematicOperations operations = new ArithematicOperations();

            //get first number
            Console.Write("Please enter the first number: ");
            int firstValue = int.Parse(Console.ReadLine());

            //get the second number
            Console.Write("Please enter the second number: ");
            int secondValue = int.Parse(Console.ReadLine());

            // calc and display
            Console.WriteLine("Result: " + operations.Calculate(firstValue, secondValue));

            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    //class your Main method is looking for
    public class ArithematicOperations
    {
        public int Calculate(int a, int b)
        {
            // You can change this logic
            return a + b;
        }
    }
}
