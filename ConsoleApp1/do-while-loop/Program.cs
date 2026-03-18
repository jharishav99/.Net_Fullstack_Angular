using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banned_words = { "Dumb", "Stupid", "Idiot" };
            string article = "here this is the first time i am using visual studio it makes me look Idiot cause i don't know how to use";

            bool check = false;
            string status = "Accepted";

            do
            {
                for (int i=0; i<banned_words.Length; i++)
                {
                    bool isFound = article.Contains(banned_words[i]);
                    if (isFound)
                    {
                        status = "Rejected";
                        check = false;
                    }

                }
                check = false;
            }while (check);
            Console.WriteLine(status);
        }
    }
}
