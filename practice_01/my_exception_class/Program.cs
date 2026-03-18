using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_exception_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleProcessor processor = new SimpleProcessor();


            Console.WriteLine(" Test 1");
            processor.ProcessData(-5);

            Console.WriteLine("\nTest 2 ");

            processor.ProcessData(10);

            Console.ReadKey();
        }
    }
    public class MyExceptionClass : Exception
    {
     
        public MyExceptionClass(string message) : base(message)
        {
        }
    }

  
    public class SimpleProcessor
    {
        public void ProcessData(int value)
        {
            try
            {
                Console.WriteLine("Starting Process...");

                if (value < 0)
                {
                    
                    throw new MyExceptionClass("Negative values are not allowed!");
                }

                Console.WriteLine("Process completed successfully with value: " + value);
            }
            catch (MyExceptionClass ex)
            {
               
                Console.WriteLine("Caught Custom Error: " + ex.Message);
            }
            catch (Exception ex)
            {
              
                Console.WriteLine("Caught General Error: " + ex.Message);
            }
            finally
            {
                
                Console.WriteLine("Closing resources...");
            }
        }
    }
}
