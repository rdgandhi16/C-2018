using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basic_C_Selenium;

namespace Basic_C_Selenium.ExtentionMethod
{
    public static class WebDriverExtension
    {
        public static void SendKeysWithSplChar(this IWebDriver driver, string keys, string splchar)
        {
            driver.SendKeys(keys);
            driver.SendKeys(splchar);

        }
    }
}
