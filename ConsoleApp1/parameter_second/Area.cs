using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace parameter_second
{
    internal class Area
    {
        private int length;
        private int width=0;

        public Area (int l, int b)
        {
            length =l;
            width =b;
        }
        public Area (int l)
        {
            length = l;
        }
        public int Mycalc()
        {
            if(width==0)
            {
                return length * length;
            }
            else
            {
                return length * width;
            }
        }

    }
}
