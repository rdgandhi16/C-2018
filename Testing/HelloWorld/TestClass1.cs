using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class TestClass1
    {
        private int i = 0;

        public void SetValue(int values)
        {
            i = values;
        }

        public void GetValue()
        {
            Console.WriteLine("The value of i is :" + i);
        }
        public void TestCase1(string result)
        {
            Console.WriteLine("Hi this is TestCase-1 Class.." + result);
        }

        public void TestCase2(string result)
        {
            Console.WriteLine("Hi this is TestCase-2 Class.."+ result);
        }
    }
}
