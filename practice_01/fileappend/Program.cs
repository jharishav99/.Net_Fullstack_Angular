using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileappend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Filepath = "example1.txt";
            string additionalcontent = "This is the new append";
            try
            {
                File.AppendAllText(Filepath, additionalcontent + Environment.NewLine);
                Console.WriteLine("Written");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
        }
    }
}
