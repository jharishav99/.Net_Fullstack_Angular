using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>(); // stack = LIFO
            st.Push(1);
            st.Push(2);
            st.Push(3);

            Console.WriteLine(st.Peek()); // 3
            Console.WriteLine(st.Pop()); // remove 3
            Console.WriteLine(st.Peek()); // 2


            Queue<string> countries = new Queue<string>(); // queue = FIFO
            countries.Enqueue("Nepal");
            countries.Enqueue("US");
            countries.Enqueue("Australia");
            countries.Enqueue("Germany");
            countries.Enqueue("Canada");

            Console.WriteLine(countries.Peek());  // Nepal
            Console.WriteLine(countries.Dequeue()); // Remove Nepal
            Console.WriteLine(countries.Peek()); // US
        }
    }
}
