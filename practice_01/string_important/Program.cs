using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_important
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Find length of a string
            string s1 = "Hello";
            Console.WriteLine(s1.Length);

            // 2. Convert string to uppercase
            Console.WriteLine("welcome".ToUpper());

            // 3. Convert string to lowercase
            Console.WriteLine("DOTNET".ToLower());

            // 4. Concatenate two strings
            Console.WriteLine("Hello" + " " + "C#");

            // 5. Check if a string is empty or null
            string empty = "";
            Console.WriteLine(string.IsNullOrEmpty(empty));

            // 6. Get first character of a string
            string india = "India";
            Console.WriteLine(india[0]);

            // 7. Get last character of a string
            Console.WriteLine(india[india.Length - 1]);

            // 8. Compare two strings (case-sensitive)
            Console.WriteLine("abc" == "ABC");

            // 9. Check if string contains a word
            Console.WriteLine("Welcome to C#".Contains("C#"));

            // 10. Trim leading and trailing spaces
            Console.WriteLine(" Hello World ".Trim());

            // 11. Reverse a string
            string rev = "CSharp";
            char[] arr = rev.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine((arr));

            // 12. Count number of vowels
            string edu = "Education";
            int vowelCount = 0;
            foreach (char c in edu.ToLower())
                if ("aeiou".Contains(c)) vowelCount++;
            Console.WriteLine(vowelCount);

            // 13. Count number of consonants
            string hello = "Hello";
            int consCount = 0;
            foreach (char c in hello.ToLower())
                if (char.IsLetter(c) && !"aeiou".Contains(c))
                    consCount++;
            Console.WriteLine(consCount);

            // 14. Check if a string is a palindrome
            string pal = "madam";
            bool isPalindrome = true;
            int l = 0, r = pal.Length - 1;
            while (l < r)
            {
                if (pal[l++] != pal[r--])
                {
                    isPalindrome = false;
                    break;
                }
            }
            Console.WriteLine(isPalindrome);

            // 15. Count words in a sentence
            Console.WriteLine("I love C Sharp"
     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length);

            // 16. Replace spaces with underscore
            Console.WriteLine("Full Stack Developer".Replace(" ", "_"));

            // 17. Find index of first occurrence of a character
            Console.WriteLine("programming".IndexOf('g'));

            // 18. Remove all white spaces from a string
            Console.WriteLine("C Sharp Language".Replace(" ", ""));

            // 19. Check if string starts with a substring
            Console.WriteLine("www.google.com".StartsWith("www"));

            // 20. Check if string ends with a substring
            Console.WriteLine("file.txt".EndsWith(".txt"));

            // 21. Count frequency of each character
            string banana = "banana";
            Dictionary<char, int> freq = new Dictionary<char, int>();
            foreach (char c in banana)
            {
                if (!freq.ContainsKey(c)) freq[c] = 0;
                freq[c]++;
            }

            // 22. Remove duplicate characters from a string
            string prog = "programming";
            string unique = "";
            foreach (char c in prog)
                if (!unique.Contains(c)) unique += c;
            Console.WriteLine(unique);

            // 23. Find first non-repeating character
            string swiss = "swiss";
            foreach (char c in swiss)
            {
                if (swiss.IndexOf(c) == swiss.LastIndexOf(c))
                {
                    Console.WriteLine(c);
                    break;
                }
            }

            // 24. Check if two strings are anagrams
            string a = "listen";
            string b = "silent";
            char[] a1 = a.ToCharArray();
            char[] a2 = b.ToCharArray();
            Array.Sort(a1);
            Array.Sort(a2);
            Console.WriteLine(new string(a1) == new string(a2));

            // 25. Capitalize first letter of each word
            string sentence = "welcome to c sharp";
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }

            // 26. Find longest word in a sentence
            string line = "C sharp string manipulation";
            string longest = "";
            foreach (string w in line.Split(' '))
                if (w.Length > longest.Length) longest = w;
            Console.WriteLine(longest);

            // 27. Count occurrences of a substring
            string main = "abababab";
            string sub = "ab";
            int count = 0, index = 0;
            while ((index = main.IndexOf(sub, index)) != -1)
            {
                count++;
                index += sub.Length;
            }
            Console.WriteLine(count);

            // 28. Extract domain from an email address
            string email = "user@gmail.com";
            int atIndex = email.IndexOf('@');
            Console.WriteLine(email.Substring(atIndex + 1));

            // 29. Mask all but last 4 characters
            string number = "1234567890";
            Console.WriteLine(new string('*', number.Length - 4) + number.Substring(number.Length - 4));
            // 30. Validate password strength
            string password = "Test@123";
            bool valid =
                password.Length >= 8 &&
                password.Any(char.IsUpper) &&
                password.Any(char.IsLower) &&
                password.Any(char.IsDigit) &&
                password.Any(c => !char.IsLetterOrDigit(c));
            Console.WriteLine(valid);
        }
    }
}
