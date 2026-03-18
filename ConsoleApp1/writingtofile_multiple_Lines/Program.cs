using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace writingtofile_multiple_Lines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example.txt";
            string[] lines = {
            "This is the first line.",
            "This is the second line.",
            "This is the third line."
        };

            try
            {
                File.WriteAllLines(filePath, lines);
                Console.WriteLine("Lines written to file.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

            }
        }
    }
}