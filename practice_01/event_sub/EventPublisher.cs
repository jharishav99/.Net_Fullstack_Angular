using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_sub
{
    public delegate void MyDelegate(string message);

    internal class EventPublisher
    {
        public event MyDelegate MyEvent;

        public void MyMethod(string y)
        {
            
            MyEvent.Invoke(y);
        }
    }
}