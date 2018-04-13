using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringVariable
{
    class Program
    {
        //Declaring Variable
        static void Main(string[] args)
        {
            int a=5;

            double b = 5.5;
            string c = "Hello World";
            bool d = true;
            char e='a';

            a = 6;

            a += a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine(d);

            Console.WriteLine(e);

            Console.ReadLine();

        }
    }
}
