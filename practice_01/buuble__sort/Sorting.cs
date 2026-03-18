using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    internal class SelectionSortExample
    {
        public void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            // One by one move the boundary of the unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in the unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                }

                // Swap the found minimum element with the first element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }

            // Printing the sorted array
            Console.WriteLine("\nSorted using Selection Sort:");
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            }
        }
}
