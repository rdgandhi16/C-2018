﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevInt_Infy
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            while(number>0)
            {
                result = result * 10 + number % 10;
                number = number / 10;
            }
            Console.Write(result);
            Console.ReadLine();
        }
    }
}
