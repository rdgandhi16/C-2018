using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Implicit_Explicit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion
            int val1 = 100;

            double val2 = val1;

            Console.WriteLine(val2);

            //Explicit Conversion

            int val3 = 1000;

            double val4 = val3;

            int val5 = (int)val4;

            Console.WriteLine(val5);

            // No data loss in Implicit conversion 
            Int16 salary = 32767;
            int SalaryIncrement = salary;
            SalaryIncrement = 32767500;

            Console.WriteLine(SalaryIncrement);


            //Data Loss in Expicit conversion
            double incomeTax = 2345.2345d;

            Console.WriteLine((int)incomeTax);


            double amount = 10;
            Money money = new Money(amount);

            int convertedAmount = Convert.ToInt16(money.Amount);

            string[] arr = { "Rinkal Gandhi", "Roma Modi", "Vishal", "Anand", "Binal", "Dhara" };

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i].Contains(" "))
                {
                    Console.WriteLine(arr[i]);
                }
            }
        Console.ReadLine();
        }

        //Money class  
        public class Money
        {
            public double Amount { get; set; }

            public Money(double amount)
            {
                Amount = amount;
            }
        }


    }
    


}
