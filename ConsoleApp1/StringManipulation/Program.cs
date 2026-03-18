using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Rishav Jha";
            int length = name.Length;
            Console.WriteLine($"String length is :- {length}"); // 10 (count space too)

            Console.WriteLine(name.ToUpper()); // RISHAV JHA
            Console.WriteLine(name.ToLower()); // rishav jha

            Console.WriteLine(name.Replace("Rishav", "R")); // R Jha

            Console.WriteLine(name.Substring(3)); //  hav jha   [Starts from the index to end)

            Console.WriteLine(name.Contains("s")); // True
            Console.WriteLine(name.Contains("jha")); // False
            Console.WriteLine(name.Contains("Jha")); // True

            Console.WriteLine(name.IndexOf("J")); // 7
            Console.WriteLine(name.IndexOf("a")); // 4
            Console.WriteLine(name.IndexOf("j")); // -1  // not found value = -1

            string animal = " snow leopard ";
            Console.WriteLine(animal); // [ snow leopard]
            Console.WriteLine(animal.Trim()); //[snow leopard] // remove the whitespace of front part
            Console.WriteLine(animal.TrimEnd()); // remove the whitespace of end part

            string str = "Hello from Kathmandu,Nepal";
            string[] split = str.Split(' ');
            foreach (string s in split)
            {
                Console.WriteLine(s);  
                //Hello
                //from
                //Kathmandu,Nepal
            }

            string[] profile = { "snow", "leopard", "antartica" };
            string result = string.Join(" ", profile);
            Console.WriteLine(result); // snow leopard antartica

            string channel_name = "national geo-graphic";
            Console.WriteLine(channel_name.StartsWith("national")); //True
            Console.WriteLine(channel_name.StartsWith("nat")); //True
            Console.WriteLine(channel_name.StartsWith("National")); //False
            Console.WriteLine(channel_name.EndsWith("geo-graphic")); //True
            Console.WriteLine(channel_name.EndsWith("hic")); //True
            Console.WriteLine(channel_name.EndsWith("Geo-graphic")); //False


            string animal1 = "panther";
            string location1 = "Africa";
            string sentence = string.Format("The animal name is {0} and it's in {1}",animal1,location1);
            Console.WriteLine(sentence);
            // The animal name is panther and it's in Africa
            Console.WriteLine($"The animal name is {animal1} and it's in {location1}");

            string num = "123";
            Console.WriteLine(num.PadLeft(10,'9'));  // 9999999123
            // 10 = total including (123) 
            // 9 means = adding number 9 in left 
            // result = 9999999123
            Console.WriteLine(num.PadRight(3,'0')); // 123
            // result = 123 as it is cause 123=3 words and input is total 3 words
            // resulr = 123000 if PadRight(6,'0');
            Console.WriteLine(num.PadRight(6, '0')); // 123000

            Console.WriteLine("Nepal".Equals("nepal")); //false
            Console.WriteLine("Nepal".Equals("Nepal")); //True
            Console.WriteLine("Nepal".Equals(" Nepal")); //False

            // chars []  -> access character by index
            string jungle_King = "lion";
            Console.WriteLine(jungle_King[0]);// l 
            Console.WriteLine(jungle_King[3]);// n 

            string text1 = "";
            string text2 = " ";
            Console.WriteLine(string.IsNullOrEmpty(text1)); // true
            Console.WriteLine(string.IsNullOrEmpty(text2)); // false
            Console.WriteLine(string.IsNullOrWhiteSpace(text2)); // true

            int result1 = string.Compare("Nepal", "India");
            int result2 = string.Compare("India", "Nepal");
            int result3 = string.Compare("Nepal", "Nepal");
            Console.WriteLine(result1); // 1 (first is after)
            Console.WriteLine(result2); // -1 (first is before)
            Console.WriteLine(result3); // 0 (same)

            // ComapareTo -> same as compare but instance method
            int result4 = "apple".CompareTo("banana");
            Console.WriteLine(result4); // -1

            Console.WriteLine("mount everest".Equals("Mount Everest")); // False

            string text10 = "national geo";
            Console.WriteLine(text10.Remove(8)); // national
            Console.WriteLine(text10.Remove(1,3)); // nonal geo   [removes index from 1 to 3]

            Console.WriteLine(text10.Insert(12, "graphic")); // national geographic

            string result_final = string.Concat("RISHAV"," ", text10); // RISHAV national geo
            Console.WriteLine(result_final);

            object obj = "black panther";
            string text = obj.ToString(); // converts obj to string

            string te = "nepal nepal";  
            // 0 1 2 3 4 5 6 7 8 9 
            // n e p a l   n e p a   -> nepal first index n=6 in the last index
            Console.WriteLine(te.LastIndexOf("nepal")); // 6

            int result12 = string.CompareOrdinal("nepal", "india");
            int result13 = string.CompareOrdinal("india", "nepal");
            int result14 = string.CompareOrdinal("nepal", "nepal");
            Console.WriteLine(result12); // 5
            Console.WriteLine(result13); // -5
            Console.WriteLine(result14); // 0

            string tex = "e\u0301";
            Console.WriteLine(tex.Normalize()); // e

            char[] chars = "nepal".ToCharArray();

            foreach (char c in chars)
            {
                Console.WriteLine(c);
                // n
                // e
                // p
                // a
                // l
            }
            Console.WriteLine("------------");
            int index123 = "rishav".IndexOfAny(new char[] { 'a', 'i' });
            Console.WriteLine(index123); // 1
            // it will search in string which range comes first either a or i and return the index

            int index456 = "black panther".LastIndexOfAny(new char[] { 'a', 'n' });
            Console.WriteLine(index456);
            // same but from last


            Console.ReadLine();




        }
    }
}
