using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_Selenium.Browser
{
    class IE : IWebDriver
    {
        public void Click()
        {
            Console.WriteLine("Click the Element into the IE..");
        }

        public void FindElement()
        {
            Console.WriteLine("Find the element into the IE");
        }

        public void SendKeys(string keys)
        {
            Console.WriteLine("Send the Text from IE :");
        }
    }
}
