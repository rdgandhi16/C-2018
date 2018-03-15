using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter you number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = check_prime(number);
            if (result==0)
            {
                Console.WriteLine("Number is not Prime...");
            }
            else
            {
                Console.WriteLine("Number is  Prime....");
            }
            Console.ReadLine();
        }

        private static int check_prime(int number)
        {
            int i;
            for (i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    return 0;
                }
                if (i==number)
                {
                    return 1;
                }
                else
                {
                    return 1;
                }
            }
            return 0;
        }
}
}
