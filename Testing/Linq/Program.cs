
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            ListUser();
            Console.ReadLine();
        }

        public static void ListUser()
        {
            List<Users> users = new List<Users>();
            users.Add(new Users { USerId = 1, Name = "Rinkal", Age = 30, Email = "rr@r.com", Phone = 1000012301, Addresses=new Address { Street="123 Wellington Street", Country="England", FirstName="Rinkal"} });
            users.Add(new Users { USerId = 2, Name = "Roma Modi", Age = 24, Email = "cs@cs.com", Phone = 1111111111, Addresses=new Address { Street = "13000 Wilkes Way", Country = "USA", FirstName = "Roma" } });
            users.Add(new Users { USerId = 3, Name = "Anand Panchal", Age = 25, Email = "caa@csa.com", Phone = 102345689, Addresses = new Address { Street = "Wilkes Way", Country = "USA", FirstName = "Anand" } });


            //1st method
            //foreach (var user in users)
            //{
            //    if (user.Name.Contains(" "))
            //    {
            //        Console.WriteLine(user.Name);
            //    }
            //}


            //2nd Method
            //var query = from user in users where user.Name.Contains(" ") select user.Name;

            //foreach (var u in query)
            //{
            //    Console.WriteLine(u);

            //}

            var userList = from user in users select new { Firstname = user.Name, PhoneNumber = user.Phone, AddressUser = user.Addresses };

            foreach (var a in userList)
            {
                Console.WriteLine("User {0} has Phone Number {1} " , a.Firstname, a.PhoneNumber);
            }
           

        }
    }
}
