using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash_and_sorted_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Nepal");
            ht.Add(2, "England");
            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(1, "Country");
            sl.Add(3, "District");
            sl.Add(2, "State");
            foreach(KeyValuePair<int,string> kvp in sl)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
    }
}
