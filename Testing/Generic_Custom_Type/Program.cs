using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Custom_Type
{
    class Program
    {
        static void Main(string[] args)
        {

            GenericCustomType();
            Console.ReadLine();
        }


        public static void GenericCustomType()
        {
            //List<User> users = new List<User>();
            //users.Add(new User { UserId = 1, Name = "Rinkal", Age = 30, Email = "rr@r.com", Phone = 000000000 });
            //users.Add(new User { UserId = 2, Name = "Clay", Age = 24, Email = "cs@cs.com", Phone = 1111111111 });
            //users.Add(new User { UserId = 2, Name = "Anand", Age = 25, Email = "caa@csa.com", Phone = 102345689 });

            List<User> users = new List<User>()
            {
                new User
                {
                    UserId=1,
                    Name="Rinkal",
                    Email="rr@r.com",
                    Phone = 012345678
                }
                , new User
                {
                    UserId=2,
                    Name="Roma",
                    Email="rm@rm.com",
                    Phone =777777777
                },
                new User
                {
                    UserId=3,
                    Name="Anand",
                    Email="ad@ad.com",
                    Phone = 888888888
                }
            };

            foreach (var user in users)
            {
                Console.WriteLine("The User {0} has Email {1} and Phone Number is {2}", user.Name,  user.Email, user.Phone);
            }
        }
    }
    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public int Phone { get; set; }
    }
}
