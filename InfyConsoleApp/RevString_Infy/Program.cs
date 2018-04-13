using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevString_Infy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";

            int i = input.Length - 1;
            while(i>=0)
            {
                output += input[i];
                i--;
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
