using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 2, 7, 2, 9, 4, 1 };

            // Sort array in ASCENDING order (Bubble Sort)
            int[] ascArr = (int[])arr.Clone();
            for (int i = 0; i < ascArr.Length - 1; i++)
            {
                for (int j = 0; j < ascArr.Length - 1 - i; j++)
                {
                    if (ascArr[j] > ascArr[j + 1])
                    {
                        int temp = ascArr[j];
                        ascArr[j] = ascArr[j + 1];
                        ascArr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Ascending order:");
            PrintArray(ascArr);

            //  Sort array in DESCENDING order
            int[] descArr = (int[])arr.Clone();
            for (int i = 0; i < descArr.Length - 1; i++)
            {
                for (int j = 0; j < descArr.Length - 1 - i; j++)
                {
                    if (descArr[j] < descArr[j + 1])
                    {
                        int temp = descArr[j];
                        descArr[j] = descArr[j + 1];
                        descArr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Descending order:");
            PrintArray(descArr);

            // Remove duplicate elements
            Console.WriteLine("Array without duplicates:");
            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            //  Count occurrence of a given element
            int target = 4;
            int count = 0;
            foreach (int num in arr)
            {
                if (num == target)
                    count++;
            }
            Console.WriteLine($"Occurrences of {target} = {count}");

            //  Find second largest element
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }
            Console.WriteLine("Second largest = " + secondLargest);

            // Find second smallest element
            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int num in arr)
            {
                if (num < smallest)
                {
                    secondSmallest = smallest;
                    smallest = num;
                }
                else if (num < secondSmallest && num != smallest)
                {
                    secondSmallest = num;
                }
            }
            Console.WriteLine("Second smallest = " + secondSmallest);

            //  Rotate array LEFT by 1 position
            int[] leftRotate = (int[])arr.Clone();
            int first = leftRotate[0];
            for (int i = 0; i < leftRotate.Length - 1; i++)
            {
                leftRotate[i] = leftRotate[i + 1];
            }
            leftRotate[leftRotate.Length - 1] = first;

            Console.WriteLine("Left rotated by 1:");
            PrintArray(leftRotate);

            //  Rotate array RIGHT by 1 position
            int[] rightRotate = (int[])arr.Clone();
            int last = rightRotate[rightRotate.Length - 1];
            for (int i = rightRotate.Length - 1; i > 0; i--)
            {
                rightRotate[i] = rightRotate[i - 1];
            }
            rightRotate[0] = last;

            Console.WriteLine("Right rotated by 1:");
            PrintArray(rightRotate);

            //  Check if array is sorted (ascending)
            bool isSorted = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    isSorted = false;
                    break;
                }
            }
            Console.WriteLine("Is array sorted? " + isSorted);

            //  Merge two arrays
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };

            int[] merged = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
                merged[i] = arr1[i];

            for (int i = 0; i < arr2.Length; i++)
                merged[arr1.Length + i] = arr2[i];

            Console.WriteLine("Merged array:");
            PrintArray(merged);
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
                Console.Write(num + " ");
            Console.WriteLine();
        }
    }
}
