using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        // Label for the Class Programm..
        Program p = new Program();
        
        // Entry Point of your Program
        static void Main(string[] args)
        {

            TestClass1 tc1 = new TestClass1();
            tc1.TestCase1("Passed");
            tc1.TestCase2("Failed");
            tc1.SetValue(10);
            tc1.SetValue(100);

            tc1.GetValue();


            TestClass1 tc2 = new TestClass1();
            tc2.SetValue(1000);
            tc2.GetValue();
            Console.WriteLine("WelCome to DotNet Testing...");
            Console.ReadLine();
        }
    }
}
