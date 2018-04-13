using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] emp = new string[3];
            emp[0] = "Rinkal";
            emp[1] = "Roma";
            emp[2] = "John";

            string[][] jaggedArray = new string[3][];

            jaggedArray[0] = new string[3];
            jaggedArray[1] = new string[1];
            jaggedArray[2] = new string[2];

            jaggedArray[0][0] = "Bachelors";
            jaggedArray[0][1] = "Master";
            jaggedArray[0][2] = "Doctorate";

            jaggedArray[1][0] = "Bachelors";

            jaggedArray[2][0] = "Bachelors";
            jaggedArray[2][1] = "Master";

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine("------");
                Console.WriteLine(emp[i]);
                Console.WriteLine("---------------------");
                string[] innerarray = jaggedArray[i];
                for (int j = 0; j < innerarray.Length; j++)
                {
                    Console.WriteLine(innerarray[j]);
                }
            }
            Console.ReadLine();
        }
    }
}
