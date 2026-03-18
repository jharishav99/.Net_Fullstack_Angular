using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_practice_qn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //qn1
            string str1 = "Hello";
            Console.WriteLine(str1.Length);
            
            //qn2
            string to_upper = "welcome";
            Console.WriteLine(to_upper.ToUpper());

            //qn3
            string input = "DOTNET";
            Console.WriteLine(input.ToLower());

            //qn4
            string s1 = "Hello";
            string s2 = "C#";
            Console.WriteLine(s1 + " " + s2);

            //qn5
            string s = "";
            Console.WriteLine(string.IsNullOrEmpty(s));

            //qn6
            string country = "India";
            Console.WriteLine(country[0]);

            //qn7
            Console.WriteLine(country[country.Length - 1]);

            //qn8
            String a = "abc";
            String A = "ABC";
            // Console.WriteLine(string.Compare(a, A));  = -1
            bool result = (a == A);
            Console.WriteLine(result);

            //qn9
            string check = "Welcome to C#";
            bool result1 = check.Contains("C#");
                Console.WriteLine(result1);

            //qn10
            string hello = " Hello World";
            Console.WriteLine(hello.Trim());

            //qn11
            string rev = "CSharp";
            //Console.WriteLine(string.Reverse(rev));
            string result123 = new string(rev.Reverse().ToArray());
            Console.WriteLine(result123);

            //qn12 & 13
            //string volwels = "Education";
            //string consonants = "Hello";

            int v1 = "Education".Count(c => "aAeEiIoOuU".Contains(c));
            int c1 = "Hello".Count(c => char.IsLetter(c) && !"aAeEiIoOuU".Contains(c));
            Console.WriteLine(v1);
            Console.WriteLine(c1);

            //qn14
            string pal = "madam";
            string pal1 = new string(pal.Reverse().ToArray());
            Console.WriteLine(pal);
            Console.WriteLine(pal1);
            bool checking = (pal == pal1);
            Console.WriteLine(checking);

            //qn15
            //string counter = "I love C Sharp";
            //Console.WriteLine(counter.);

          
            //qn16
            string rep = "Full Stack Developer";
            string output_rep = rep.Replace(" ", "_");
            Console.WriteLine(output_rep);

            //qn17
            string qw = "programming";
            Console.WriteLine(qw.IndexOf("g"));

            //qn18
            string remo = "C Sharp Language";
            // Console.WriteLine(string.IsNullOrWhiteSpace(remo));
            Console.WriteLine(remo.Replace(" ", ""));

            //qn19 & qn20
            string asd1 = "www.google.com";
            string asd2 = "file.txt";
            Console.WriteLine(asd1.StartsWith("www"));
            Console.WriteLine(asd2.EndsWith(".txt"));

            //qn21
            string fruits = "banana";
            Dictionary<char, int> dict = new Dictionary<char,int>();
            foreach(char c in fruits)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else { dict[c] = 1; }
            }
            foreach(var item in dict)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            //qn22
            string inputa = "programming";
            string outputb = "";
            foreach(char c in inputa)
            {
                if(!outputb.Contains(c))
                {
                    outputb += c;
                }
            }
            Console.WriteLine(outputb);


            //qn23
            string zxc = "swiss";
            foreach (char c in zxc)
            {
                if(zxc.IndexOf(c) ==zxc.LastIndexOf(c))
                {
                    Console.WriteLine(c);
                    break;
                }
            }
            //qn24
            string z1 = "silent";
            string z2 = "listen";

            char[] cz1 = z1.ToCharArray();
            char[] cz2 = z2.ToCharArray();
            Array.Sort(cz1);
            Array.Sort(cz2);
            bool is_anagram = new string(cz1) == new string(cz2);
            Console.WriteLine(is_anagram);

            //qn25
            string input_a1 = "welcome to c sharp";
            string[] words_a1 = input_a1.Split(' ');

            for (int i = 0; i < words_a1.Length; i++)
            {
                words_a1[i] = char.ToUpper(words_a1[i][0]) + words_a1[i].Substring(1);
            }

            string result_a1 = string.Join(" ", words_a1);
            Console.WriteLine(result_a1);

            //qn26
            string inputabc = "C sharp string manipulation";
            string[] wordsa = inputabc.Split(' ');

            string longest = wordsa[0];

            foreach (string word in wordsa)
            {
                if (word.Length > longest.Length)
                    longest = word;
            }

            Console.WriteLine(longest);

            //qn27
            string inputq = "abababab";
            string subq = "ab";
            int countq = 0;
            int indexq = 0;

            while ((indexq = inputq.IndexOf(subq, indexq)) != -1)
            {
                countq++;
                indexq += subq.Length;
            }

            Console.WriteLine(countq);

            //qn28
            string email = "user@gmail.com";

            string domain = email.Substring(email.IndexOf('@') + 1);
            Console.WriteLine(domain);

            //qn29

            string input_last = "1234567890";

            string masked = new string('*', input_last.Length - 4) + input_last.Substring(input_last.Length - 4);
            Console.WriteLine(masked);


            //qn30






































            Console.ReadKey();

        }
    }
}
