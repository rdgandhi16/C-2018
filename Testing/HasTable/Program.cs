using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasTable
{
    class Program
    {
        static void Main(string[] args)
        {
            NonGenericCollection();
            GenereticTypeCollectio();
            Console.ReadLine();
        }

        public static void NonGenericCollection()
        {
            Hashtable table = new Hashtable();
            table.Add("UserName", "Rinkal");
            table.Add("Password", "1234");
            table.Add("Button", "Submit");

            foreach (var key in table.Keys)
            {
                Console.WriteLine("The Value for the " +key+ " is :" + table[key]);
            }       
        }

        public static void GenereticTypeCollectio()
        {
            string[] user1 = { "Rinkal", "Male", "Atlanta" };
            string[] user2 = { "Roma", "Female", "Lawrenceville" };
            string[] user3 = { "Ananad", "Male", "Chikhli" };
            string[] user4 = { "Dhara", "Female", "Gandevi" };

            Dictionary<int, string[]> dict = new Dictionary<int, string[]>();
            dict.Add(1, user1);
            dict.Add(2, user2);
            dict.Add(3, user3);
            dict.Add(4, user4);

            foreach (var value in dict)
            {
                string[] UsersInfo = value.Value;

                foreach (var user in UsersInfo)
                {
                    Console.WriteLine(user);
                }
                Console.WriteLine("------------------------------");
            }
            Console.ReadLine();

        }
    }
}
