using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delegates_example de = new Delegates_example();
            List<int> results = new List<int>(); // to get output of sum,sqaure
            Func<int, int> f1 = de.Square;
            f1 += de.Double;
            Console.WriteLine(f1(10));
            var Invoclist = f1.GetInvocationList().Cast<Func<int, int>>();
            foreach (var invlist in Invoclist)
                {

                int result = invlist.Invoke(10);
                results.Add(result);
            }
            foreach (int i in results)
            { Console.WriteLine(i); 
            }

            // action -> for void or no return type
            Action<int> a = de.Cube;   

            a(10);

            var invocListA = a.GetInvocationList().Cast<Action<int>>();
            foreach (var method in invocListA)
            {
                method.Invoke(10);  
            } 
    }
    public class Delegates_example
    {
    
        public int Double(int x)
        {
            return x + x;
        }
        public int Square(int x)
        {
            return x * x;
        }
        public void Cube(int x)
        {
            return x * x * x;
        }
    
    }

}
