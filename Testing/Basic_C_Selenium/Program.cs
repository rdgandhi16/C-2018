using Basic_C_Selenium.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basic_C_Selenium.ExtentionMethod;

namespace Basic_C_Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new Chrome();

            driver.FindElement();
            driver.SendKeysWithSplChar("executeautomation", "!!!!");


            Console.ReadLine();
        }
    }
}
