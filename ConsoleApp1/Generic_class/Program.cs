using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generic_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Using it with an Integer
            DataResponse<int> scoreResponse = new DataResponse<int>();
            scoreResponse.Data = 100;
            scoreResponse.Success = true;
            scoreResponse.Message = "int";
            scoreResponse.PrintDetails();

            // 2. Using it with a String
            DataResponse<string> nameResponse = new DataResponse<string>();
            nameResponse.Data = "Alex";
            nameResponse.Success = true;
            nameResponse.Message = "string";
            nameResponse.PrintDetails();
        }
    }
    public class DataResponse<T>
    {
        public T Data {  get; set; }
        public bool Success { get; set;}
        public string Message { get; set;}


        public void PrintDetails()
        {
            Console.WriteLine($"Staus:{Success} | Message:{Message}");
            Console.WriteLine($"Data value: {Data}");
            
        }

    }

}
