using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encap
{
    public class Class1
    {
        private string Message;

    public Class1(string Gender)
        {
            Message= Gender;
        }
    public int Greetings() {
            {
               if(Message=="Male") return { "Sir"};
                else return "Ma'am"
            }
    }
}
