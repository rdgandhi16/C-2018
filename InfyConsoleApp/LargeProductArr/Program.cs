using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeProductArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 9, 7, 10, 20, 1 };

            int max = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]*arr[i+1]>max)
                {
                    max = arr[i] * arr[i + 1];
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();


        }
    }
}
