using System;
using System.Linq;

namespace Reversestring
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            Console.WriteLine(output);


            //string op = new string(input.ToCharArray().Reverse().ToArray());
            //Console.WriteLine(op);


            //string ip = "Hwllo World";
            //char[] array = ip.ToCharArray();
            //Array.Reverse(array);
            //string op = new string(array);
            //Console.WriteLine(op);
            Console.ReadLine();
        }
    }
}
