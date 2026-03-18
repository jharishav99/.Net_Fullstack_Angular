using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_direct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dirPath = "newDirectory";
            string filePath = dirPath + @"\example.text";

            try
            {
                // Create the directory if it doesn't exist
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                    Console.WriteLine("Directory created successfully.");
                }
                else
                {
                    Console.WriteLine("Directory already exists.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            string[] lines = {
            "This is the first line.",
            "This is the second line.",
            "This is the third line."
        };

            try
            {
                File.AppendAllLines(filePath, lines);
                Console.WriteLine("Lines written to file.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }


        }
    }
    }

