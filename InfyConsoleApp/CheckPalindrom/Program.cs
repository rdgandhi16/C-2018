using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPalindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int i = 0;
            int j = str.Length - 1;

            while (i<j)
            {
                if (str[i] != str[j])
                {
                    Console.WriteLine("Given string is not Palindrom");
                }
                str +=str[j];
                i++;
                j--;

            }
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
