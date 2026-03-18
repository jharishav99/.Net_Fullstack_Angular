using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_sub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventPublisher ep = new EventPublisher();
            EventSubscriber es = new EventSubscriber();
            ep.MyEvent += es.SubscriberMethod;
            ep.MyMethod("Hello");
        }
    }
}
