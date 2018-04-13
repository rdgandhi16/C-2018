using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{

    enum Brobser
    {
        FireFox,
        Chrome,
        Opera
    }
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(GetBrowserName(Brobser.Chrome));

            Console.ReadLine();
        }

        public static string GetBrowserName(Brobser browser)
        {
            if (browser==Brobser.FireFox)
            {
                return "FireFox";
            }
            else if (browser==Brobser.Chrome)
            {
                return "Chrome";
            }
            else if (browser==Brobser.Opera)
            {
                return "Opera";
            }
            return "Nothing";
        }
    }
}
