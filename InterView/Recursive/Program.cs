using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
            Console.ReadLine();
        }

        static double Factorial(int number)
        {

            if (number==0)
                return 1;

            double fact = 1;
            for (int i = number; i >=1; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
