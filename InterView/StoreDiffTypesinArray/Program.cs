using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDiffTypesinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add("Rinkal");
            array.Add("Gandhi");

            foreach (var obj in array)
            {
                Console.WriteLine(obj);
            }

            object[] arr = new object[3];
            
            
            Customer c = new Customer();
            c.Id = 2;
            arr[0] = c.Id;
            c.FirstName = "Roma";
            arr[1] = c.FirstName;
            c.LastName = "Modi";
            arr[2] = c.LastName;

            foreach (var o in arr)
            {
                Console.WriteLine(o);
            }

            

            Console.ReadLine();
        }

    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
