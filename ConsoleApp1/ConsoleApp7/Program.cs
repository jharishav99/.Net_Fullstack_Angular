using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string article = "According to the Federation of Nepal Gold and Silver Dealers' Association, fine gold fell by Rs 4,200 per tola to trade at Rs 291,000 per tola, down from Rs 295,200 per tola on Thursday.";
            bool check = article.Contains("gold");
            if(check)
            {
                Console.WriteLine("Rejected");
            }
            else
            {
                Console.WriteLine("Accepted");
            }
        }
    }
}
