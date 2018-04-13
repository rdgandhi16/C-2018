using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevString1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Your string which you want tpo reverse");
            string input = Console.ReadLine();
            int i = input.Length - 1;

            string output = "";

            while (i>=0)
            {
                output = output + input[i];
                i--;
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }

    }
}
