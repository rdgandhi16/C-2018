using System;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            Console.WriteLine("Enter Any Number..");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <number-1; i++)
            {
                for (int j = 2; j <number; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}
