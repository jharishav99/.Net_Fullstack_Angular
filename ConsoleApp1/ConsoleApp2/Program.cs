using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int availableTickets = 0;
            int? TotalTickets = null;
            if (TotalTickets == null)
            {
                availableTickets = 0;
            }
            else
            {
                availableTickets = (int)TotalTickets;
            }
        }
        //static void Main(string[] args)
        //{
        //    int availableTickets = 0;
        //    int? TotalTickets = null;
        //    availableTickets = TotalTickets ?? -1
        //}

    }
}
