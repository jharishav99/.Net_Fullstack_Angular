using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Create an array of 5 integers
            int[] arr = { 10, 25, 30, 7, 18 };

            // Print all elements
            Console.WriteLine("Array elements:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            //  Find the sum of all elements
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            Console.WriteLine("Sum = " + sum);

            // Find the average
            double average = (double)sum / arr.Length;
            Console.WriteLine("Average = " + average);

            //  Find the largest element
            int max = arr[0];
            foreach (int num in arr)
            {
                if (num > max)
                    max = num;
            }
            Console.WriteLine("Largest element = " + max);

            // Find the smallest element
            int min = arr[0];
            foreach (int num in arr)
            {
                if (num < min)
                    min = num;
            }
            Console.WriteLine("Smallest element = " + min);

            //  Count even and odd elements
            int evenCount = 0, oddCount = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }
            Console.WriteLine("Even count = " + evenCount);
            Console.WriteLine("Odd count = " + oddCount);

            //  Search for a given number
            int search = 30;
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == search)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine("Index of " + search + " = " + index);

            //  Copy elements to another array
            int[] copyArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                copyArr[i] = arr[i];
            }

            Console.WriteLine("Copied array:");
            foreach (int num in copyArr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Reverse the array
            Console.WriteLine("Reversed array:");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            //  Print elements at even indexes
            Console.WriteLine("Elements at even indexes:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
