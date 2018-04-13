﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_Selenium.Browser
{
    class Chrome : IWebDriver
    {
        public void Click()
        {
            Console.WriteLine("Click the Element into the Chrome..");

        }

        public void FindElement()
        {
            Console.WriteLine("Find the element into the Chrome");
        }

        public void SendKeys(string keys)
        {
            Console.WriteLine("Send the Text from Chrome :"+ keys);
        }


    }
}
