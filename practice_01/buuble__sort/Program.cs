using sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buuble__sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 5, 1, 4, 2, 8 };
            BubbleSortExample bubbleSorter = new BubbleSortExample();

            Console.WriteLine("Sorting with Bubble Sort:");
            bubbleSorter.BubbleSort(data);

            // --- Selection Sort ---
            int[] numbers = { 64, 25, 12, 22, 11 };
            SelectionSortExample selectionSorter = new SelectionSortExample();

            selectionSorter.SelectionSort(numbers);

          
        }
    }
}
