using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_sub
{
    internal class EventSubscriber
    {
        public void SubscriberMethod(string y)
        {
            Console.WriteLine(y + " The subscriber gets the event!");
        }
    }
}
