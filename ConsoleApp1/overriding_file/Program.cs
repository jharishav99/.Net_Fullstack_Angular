using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example.txt";
            string content = "This is some text to write into the file.";

            try
            {
                // Write text to the file, overwriting if the file exists
                File.WriteAllText(filePath, content);
                Console.WriteLine("Text written to file.");

                // Append text to the file
                string additionalContent = "\nThis is additional content.";
                File.AppendAllText(filePath, additionalContent);
                Console.WriteLine("Additional text appended to file.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

            }
        }
    }
}
