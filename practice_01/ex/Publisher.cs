using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    internal class Publisher
    {
        public delegate void ClickHandler();
        public event ClickHandler OnClick;

        public void Click()
        {
            Console.WriteLine("Publisher clicked");
            if (OnClick != null) OnClick();

        }
    }
}
