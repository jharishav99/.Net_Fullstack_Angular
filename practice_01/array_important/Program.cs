using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_important
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 2, 0 };

            // 1. Print all elements
            foreach (int n in arr)
                Console.Write(n + " ");
            Console.WriteLine();

            // 2. Sum of elements
            int sum = 0;
            foreach (int n in arr) sum += n;
            Console.WriteLine(sum);

            // 3. Average
            Console.WriteLine((double)sum / arr.Length);

            // 4. Largest element
            int max = arr[0];
            foreach (int n in arr)
                if (n > max) max = n;
            Console.WriteLine(max);

            // 5. Smallest element
            int min = arr[0];
            foreach (int n in arr)
                if (n < min) min = n;
            Console.WriteLine(min);

            // 6. Count even and odd
            int even = 0, odd = 0;
            foreach (int n in arr)
                if (n % 2 == 0) even++; else odd++;
            Console.WriteLine($"Even: {even}, Odd: {odd}");

            // 7. Search element
            int search = 3, index = -1;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == search) { index = i; break; }
            Console.WriteLine(index);

            // 8. Copy array
            int[] copy = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                copy[i] = arr[i];

            // 9. Reverse array (print)
            for (int i = arr.Length - 1; i >= 0; i--)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            // 10. Elements at even indexes
            for (int i = 0; i < arr.Length; i += 2)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            // 11. Sort ascending
            int[] asc = (int[])arr.Clone();
            for (int i = 0; i < asc.Length - 1; i++)
                for (int j = i + 1; j < asc.Length; j++)
                    if (asc[i] > asc[j])
                        (asc[i], asc[j]) = (asc[j], asc[i]);
            Console.WriteLine(string.Join(" ", asc));

            // 12. Sort descending
            int[] desc = (int[])arr.Clone();
            for (int i = 0; i < desc.Length - 1; i++)
                for (int j = i + 1; j < desc.Length; j++)
                    if (desc[i] < desc[j])
                        (desc[i], desc[j]) = (desc[j], desc[i]);
            Console.WriteLine(string.Join(" ", desc));

            // 13. Remove duplicates
            List<int> unique = new List<int>();
            foreach (int n in arr)
                if (!unique.Contains(n)) unique.Add(n);
            Console.WriteLine(string.Join(" ", unique));

            // 14. Count occurrences
            int target = 2, count = 0;
            foreach (int n in arr)
                if (n == target) count++;
            Console.WriteLine(count);

            // 15. Second largest
            int first = int.MinValue, second = int.MinValue;
            foreach (int n in arr)
            {
                if (n > first)
                {
                    second = first;
                    first = n;
                }
                else if (n > second && n != first)
                    second = n;
            }
            Console.WriteLine(second);

            // 16. Second smallest
            int firstMin = int.MaxValue, secondMin = int.MaxValue;
            foreach (int n in arr)
            {
                if (n < firstMin)
                {
                    secondMin = firstMin;
                    firstMin = n;
                }
                else if (n < secondMin && n != firstMin)
                    secondMin = n;
            }
            Console.WriteLine(secondMin);

            // 17. Left rotate by 1
            int[] leftRotate = (int[])arr.Clone();
            int firstEl = leftRotate[0];
            for (int i = 0; i < leftRotate.Length - 1; i++)
                leftRotate[i] = leftRotate[i + 1];
            leftRotate[leftRotate.Length - 1] = firstEl;
            Console.WriteLine(string.Join(" ", leftRotate));

            // 18. Right rotate by 1
            int[] rightRotate = (int[])arr.Clone();
            int lastEl = rightRotate[rightRotate.Length - 1];
            for (int i = rightRotate.Length - 1; i > 0; i--)
                rightRotate[i] = rightRotate[i - 1];
            rightRotate[0] = lastEl;
            Console.WriteLine(string.Join(" ", rightRotate));

            // 19. Check if sorted
            bool isSorted = true;
            for (int i = 0; i < arr.Length - 1; i++)
                if (arr[i] > arr[i + 1]) { isSorted = false; break; }
            Console.WriteLine(isSorted);

            // 20. Merge arrays
            int[] a = { 1, 2 };
            int[] b = { 3, 4 };
            int[] merged = new int[a.Length + b.Length];
            a.CopyTo(merged, 0);
            b.CopyTo(merged, a.Length);
            Console.WriteLine(string.Join(" ", merged));

            // 21. Duplicate elements
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] == arr[j])
                        Console.WriteLine(arr[i]);

            // 22. Unique elements
            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < arr.Length; j++)
                    if (i != j && arr[i] == arr[j]) isUnique = false;
                if (isUnique) Console.WriteLine(arr[i]);
            }

            // 23. Move zeroes to end
            int[] zeroMove = (int[])arr.Clone();
            int idx = 0;
            foreach (int n in zeroMove)
                if (n != 0) zeroMove[idx++] = n;
            while (idx < zeroMove.Length)
                zeroMove[idx++] = 0;
            Console.WriteLine(string.Join(" ", zeroMove));

            // 24. Split even and odd
            List<int> evens = new List<int>(), odds = new List<int>();
            foreach (int n in arr)
                if (n % 2 == 0) evens.Add(n); else odds.Add(n);

            // 25. Maximum subarray sum (Kadane)
            int maxSoFar = arr[0], currMax = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                currMax = Math.Max(arr[i], currMax + arr[i]);
                maxSoFar = Math.Max(maxSoFar, currMax);
            }
            Console.WriteLine(maxSoFar);

            // 26. Missing number (1 to N)
            int[] seq = { 1, 2, 3, 5 };
            int nVal = seq.Length + 1;
            Console.WriteLine(nVal * (nVal + 1) / 2 - seq.Sum());

            // 27. Pair with given sum
            int targetSum = 6;
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] + arr[j] == targetSum)
                        Console.WriteLine($"{arr[i]}, {arr[j]}");

            // 28. Reverse in place
            int l = 0, r = arr.Length - 1;
            while (l < r)
                (arr[l++], arr[r--]) = (arr[r], arr[l]);

            // 29. Check if arrays equal
            bool equal = a.Length == b.Length;
            for (int i = 0; equal && i < a.Length; i++)
                if (a[i] != b[i]) equal = false;
            Console.WriteLine(equal);

            // 30. Frequency of elements
            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (int n in arr)
                freq[n] = freq.ContainsKey(n) ? freq[n] + 1 : 1;
            foreach (var kv in freq)
                Console.WriteLine($"{kv.Key} -> {kv.Value}");
        }
    }
}
