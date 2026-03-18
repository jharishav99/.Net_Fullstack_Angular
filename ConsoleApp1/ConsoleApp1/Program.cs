using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            age_calc ao = new age_calc();
            Console.WriteLine("Age?");
            byte age = byte.Parse(Console.ReadLine());

            string display = ao.age_checking(age);
               Console.WriteLine(display);
            Console.ReadLine();



        }
    }

    class age_calc
    {
        public string age_checking(byte age)
        {
            string result = age < 3 ? "Hey small guy" : age < 10 ? "Hey kid" : age < 18 ? "Hey teen" : "Hey bif guy";
            return result;
        }
    }



    }
