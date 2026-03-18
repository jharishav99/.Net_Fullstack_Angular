using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renameorremovefile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string oldFilePath = "example.txt";
            string newFilePath = "renamedExample.txt";

            try
            {
                // Rename or move the file
                File.Move(oldFilePath, newFilePath);
                Console.WriteLine($"File renamed/moved to {newFilePath}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}
