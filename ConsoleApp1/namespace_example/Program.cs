using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using a=app1.Firstone;
using app2;

namespace namespace_example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  Firstone f = new Firstone(); will show error cause app1 and app2 both have same method
             
            

        }
    }
}

namespace app1
{
    public class Firstone
    {
            public void Method()
        {

        }
    }

}
namespace app2
{
    public class Firstone
    {
            public void Method()
        {

        }
    }

}


