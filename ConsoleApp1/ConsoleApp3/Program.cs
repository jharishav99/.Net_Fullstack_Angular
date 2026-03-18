using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = Console.Read();
            Char userinput = Convert.ToChar(y);
            while (userinput != 'z')
            {
                switch (userinput)
                {
                    case 'g':
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case 'r':
                        Console.BackgroundColor = ConsoleColor.Red; break;
                }
                Console.Clear();

                y = Console.Read();
                userinput = Convert.ToChar(y);
            }
        }
    }
}
